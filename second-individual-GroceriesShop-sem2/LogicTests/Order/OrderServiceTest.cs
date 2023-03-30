using Castle.Core.Resource;
using DAL.DTO;
using Logic;
using Logic.Account.Model;
using Logic.Order.Model;
using Logic.Order.Service;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicTests.Order
{
    [TestClass]
    public class OrderServiceTest
    {
        [TestMethod]
        public void TestHappyFlowGetOrderByORderID()
        {
            //Arrange
            var mock = new OrderRepositoryMock();
            var toTest = new OrderService(mock);

            //ACt
            var resultOrder = toTest.GetOrderById(1);

            //Assert
            var expected = new OrderModel(mock.GetOrderByOrderID(1)); // testing that the constructor sets all the information is in OrderModelTest

            Assert.AreEqual(resultOrder.ID, 1);
            Assert.AreEqual(resultOrder.BonusPointsEarned, 100);
            Assert.AreEqual(resultOrder.BonusPointsUsed, 23);
            Assert.IsNotNull(resultOrder.UserModel);
            Assert.AreEqual(resultOrder.UserModel.ID, 12);
            Assert.AreEqual(resultOrder.UserModel.Name, "Bogdan");
            Assert.AreEqual(resultOrder.OrderDate, DateTime.MinValue);
            Assert.IsNotNull(resultOrder.DeliveryInfo);
            Assert.AreEqual(resultOrder.DeliveryInfo, expected.DeliveryInfo);
            Assert.IsNotNull(resultOrder.ShoppingCart);
            CollectionAssert.AreEqual(expected.ShoppingCart.Items, resultOrder.ShoppingCart.Items);
            Assert.AreEqual(resultOrder.OrderStatus, "DELIVEREd");
            Assert.AreEqual(resultOrder.PaymentOption, PaymentOptions.CARD);
            Assert.AreEqual(resultOrder.Total, 100);


        }

        [TestMethod]
        public void TestHappyFlowGetAllOrdersByUser()
        {
            //Arrange
            var mock = new OrderRepositoryMock();
            var toTest = new OrderService(mock);

            //ACt
            var result = toTest.GetOrdersByCustomerID(12);

            //Assert
            var expected = new OrderModel(mock.GetOrdersByCustomerID(12)[0]); // testing that the OrderModel constructor sets all the information is in OrderModelTest
            var expectedList = new List<OrderModel>()
            {
                expected
            };
            Assert.IsNotNull(expectedList);
            Assert.IsTrue(expectedList.Count == 1);

            OrderModel resultOrder = result[0];
            Assert.AreEqual(1, resultOrder.ID);
            Assert.AreEqual(100, resultOrder.BonusPointsEarned);
            Assert.AreEqual(23, resultOrder.BonusPointsUsed);
            Assert.IsNotNull(resultOrder.UserModel);
            Assert.AreEqual(12, resultOrder.UserModel.ID);
            Assert.AreEqual( "Bogdan", resultOrder.UserModel.Name);
            Assert.AreEqual(DateTime.MinValue, resultOrder.OrderDate);
            Assert.IsNotNull(resultOrder.DeliveryInfo);
            Assert.AreEqual(expected.DeliveryInfo,resultOrder.DeliveryInfo);
            Assert.IsNotNull(resultOrder.ShoppingCart);
            CollectionAssert.AreEqual(expected.ShoppingCart.Items, resultOrder.ShoppingCart.Items);
            Assert.AreEqual("DELIVEREd", resultOrder.OrderStatus);
            Assert.AreEqual(PaymentOptions.CARD, resultOrder.PaymentOption);
            Assert.AreEqual(100, resultOrder.Total);


        }

        [TestMethod]
        public void TestHappyFlowGetAllOrders()
        {
            //Arrange
            var mock = new OrderRepositoryMock();
            var toTest = new OrderService(mock);

            //Act
            List<OrderModel> result = toTest.GetAllOrders();

            //Arrange
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count == 1);
            Assert.AreEqual(1, result[0].ID);
            Assert.AreEqual("DELIVEREd", result[0].OrderStatus);
        }

        [TestMethod]
        public void TestExceptionGetOrderByOrderId()
        {
            //Arrange
            var toTest = new OrderService(null);

            //Act && Assert
            var ex = Assert.ThrowsException<Exception>(() => toTest.GetOrderById(1));
            var expectedErrorMessage = "Error getting order by ID";

            Assert.AreEqual(expectedErrorMessage, ex.Message);
        }

        [TestMethod]
        public void TestExceptionGetAllOrders()
        {
            //Arrange
            var toTest = new OrderService(null);

            //Act && Assert
            var ex = Assert.ThrowsException<Exception>(() => toTest.GetAllOrders());
            var expectedErrorMessage = "Could not retrieve orders";

            Assert.AreEqual(expectedErrorMessage, ex.Message);
        }
        [TestMethod]
        public void TestExceptionGetAllOrdersByUserId()
        {
            //Arrange
            var toTest = new OrderService(null);

            //Act && Assert
            var ex = Assert.ThrowsException<Exception>(() => toTest.GetOrdersByCustomerID(1));
            var expectedErrorMessage = "Could not retrieve orders for customer";

            Assert.AreEqual(expectedErrorMessage, ex.Message);
        }

        [TestMethod]
        public void TestAlternativeCreateOrderWithoutBonusDiscount()
        {
            //Arrange
            var mock = new OrderRepositoryMock();
            var toTest = new OrderService(mock);

            var deliveryInfo = new AddressModel()
            {
                City = "Eindhoven",
                HouseNo = 1,
                StreeName = " Straatsburglan",
                ZipCode = "1234AA"
            };

            var orderItems = new CartModel()
            {
                Items = new List<ItemModel>()
                {
                    new ItemModel()
                    {
                        Product = new Logic.Products.Model.ProductModel()
                        {

                            ID = 1,
                            Price = 1.99
                        },
                        Quantity = 10
                    }
                },
                BonusCard = new BonusCardModel()
                {
                    BonusCardId = 1,
                    BonusPointsToApply = 0
                }
            };
            var orderModel = new OrderModel()
            {
                UserModel = new CustomerModel()
                {
                    ID = 12,
                    Name = "Bogdan"
                },
                DeliveryInfo = deliveryInfo,
                ShoppingCart = orderItems,   
                PaymentOption = PaymentOptions.CASH_ON_DELIVERY,

            };
            //Act
            toTest.CreateOrder(orderModel);

            //Assert
            //that the total price and total bonus points are calculated without discount
            Assert.AreEqual(19.9, mock.OrderDTOCreate.Total);        
            Assert.AreEqual(0, mock.OrderDTOCreate.BonusPointsUsed);        
            Assert.AreEqual(20, mock.OrderDTOCreate.BonusPointsEarned);
            Assert.IsNotNull(mock.OrderDTOCreate);
            Assert.AreEqual("Pending", mock.OrderDTOCreate.OrderStatus);
            Assert.AreEqual("CASH_ON_DELIVERY", mock.OrderDTOCreate.PaymentType);

            Assert.IsNotNull(mock.OrderDTOCreate.DeliveryAddress);
            Assert.AreEqual("Eindhoven", mock.OrderDTOCreate.DeliveryAddress.City);
            Assert.AreEqual(" Straatsburglan", mock.OrderDTOCreate.DeliveryAddress.StreeName);
            Assert.IsNotNull(mock.OrderDTOCreate.DeliveryAddress);
            Assert.AreEqual("1234AA", mock.OrderDTOCreate.DeliveryAddress.ZipCode);
            Assert.AreEqual(1, mock.OrderDTOCreate.DeliveryAddress.HouseNo);

            Assert.IsNotNull(mock.OrderDTOCreate.orderItemDTOs);
            Assert.IsTrue(mock.OrderDTOCreate.orderItemDTOs.Count == 1);
            Assert.AreEqual(1, mock.OrderDTOCreate.orderItemDTOs[0].Product_ID);
            Assert.AreEqual(10, mock.OrderDTOCreate.orderItemDTOs[0].Quantity);
            Assert.AreEqual(1.99, mock.OrderDTOCreate.orderItemDTOs[0].UnitPrice);

        }

        [TestMethod]
        public void TestAlternativeCreateOrderWithBonusDiscount()
        {
            //Arrange
            var mock = new OrderRepositoryMock();
            var toTest = new OrderService(mock);

            var deliveryInfo = new AddressModel()
            {
                City = "Eindhoven",
                HouseNo = 1,
                StreeName = " Straatsburglan",
                ZipCode = "1234AA"
            };

            var orderItems = new CartModel()
            {
                Items = new List<ItemModel>()
                {
                    new ItemModel()
                    {
                        Product = new Logic.Products.Model.ProductModel()
                        {

                            ID = 1,
                            Price = 1.99
                        },
                        Quantity = 10
                    }
                },
                BonusCard = new BonusCardModel()
                {
                    BonusCardId = 1,
                    BonusPointsToApply = 100
                }
            };
            var orderModel = new OrderModel()
            {
                UserModel = new CustomerModel()
                {
                    ID = 12,
                    Name = "Bogdan"
                },
                DeliveryInfo = deliveryInfo,
                ShoppingCart = orderItems,
                PaymentOption = PaymentOptions.CASH_ON_DELIVERY,

            };
            //Act
            toTest.CreateOrder(orderModel);

            //Assert
            //that the total price and total bonus points are calculated with discount
            Assert.AreEqual(18.9, mock.OrderDTOCreate.Total);
            Assert.AreEqual(100, mock.OrderDTOCreate.BonusPointsUsed);
            Assert.AreEqual(19, mock.OrderDTOCreate.BonusPointsEarned);
            Assert.IsNotNull(mock.OrderDTOCreate);
            Assert.AreEqual("Pending", mock.OrderDTOCreate.OrderStatus);
            Assert.AreEqual("CASH_ON_DELIVERY", mock.OrderDTOCreate.PaymentType);

            Assert.IsNotNull(mock.OrderDTOCreate.DeliveryAddress);
            Assert.AreEqual("Eindhoven", mock.OrderDTOCreate.DeliveryAddress.City);
            Assert.AreEqual(" Straatsburglan", mock.OrderDTOCreate.DeliveryAddress.StreeName);
            Assert.IsNotNull(mock.OrderDTOCreate.DeliveryAddress);
            Assert.AreEqual("1234AA", mock.OrderDTOCreate.DeliveryAddress.ZipCode);
            Assert.AreEqual(1, mock.OrderDTOCreate.DeliveryAddress.HouseNo);

            Assert.IsNotNull(mock.OrderDTOCreate.orderItemDTOs);
            Assert.IsTrue(mock.OrderDTOCreate.orderItemDTOs.Count == 1);
            Assert.AreEqual(1, mock.OrderDTOCreate.orderItemDTOs[0].Product_ID);
            Assert.AreEqual(10, mock.OrderDTOCreate.orderItemDTOs[0].Quantity);
            Assert.AreEqual(1.99, mock.OrderDTOCreate.orderItemDTOs[0].UnitPrice);

        }

        [TestMethod]
        public void TestUpdateBonusCard()
        {
            //Arrange
            var mock = new OrderRepositoryMock();
            var toTest = new OrderService(mock);

            //Act
            var input = new OrderModel()
            {
                ID = 1,
                OrderStatus = "COMPLETED"
            };
            toTest.UpdateOrderStatusByID(input);

            //Assert
            Assert.IsNotNull(mock.OrderDTOUpdate);
            Assert.AreEqual("COMPLETED", mock.OrderDTOUpdate.OrderStatus);

        }
       
        [TestMethod]
        public void TestExceptionUpdateBonusCard()
        {
            //Arrange
            var toTest = new OrderService(null);

            //Act && Assert
            var ex = Assert.ThrowsException<Exception>(() => toTest.UpdateOrderStatusByID(null));
            var expectedErrorMessage = "Could not update order";

            Assert.AreEqual(expectedErrorMessage, ex.Message);
        }

        [TestMethod]
        public void TestExceptionCreateOrder()
        {
            //Arrange
            var toTest = new OrderService(null);

            //Act && Assert
            var ex = Assert.ThrowsException<Exception>(() => toTest.CreateOrder(null));
            var expectedErrorMessage = "Could not perform Create Order Operation!";

            Assert.AreEqual(expectedErrorMessage, ex.Message);
        }

    }
}
