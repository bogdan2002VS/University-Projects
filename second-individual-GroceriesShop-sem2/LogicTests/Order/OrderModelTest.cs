using DAL.DTO;
using Logic.Account.Model;
using Logic.Order.Model;

namespace LogicTests.Order
{
    [TestClass]
    public class OrderModelTest
    {
        [TestMethod]
        public void TestConstructor()
        {
            //Arrange
            var DTO = new OrderDTO()
            {
                ID = 1,
                BonusPointsEarned = 100,
                CustomerID = 12,
                BonusPointsUsed = 23,
                CustomerName = "Bogdan",
                Modified_at = DateTime.MaxValue,
                Created_at = DateTime.MinValue,
                DeliveryAddress = new AddressDTO()
                {
                    City = "Eindhoven",
                    HouseNo = 1,
                    ID = 1,
                    StreeName = " Straatsburglan"
                },
                orderItemDTOs = new List<OrderItemDTO>()
                    {
                        new OrderItemDTO()
                        {
                            ID =11,
                            Order_ID =1,
                            ProductName ="apple",
                            Product_ID = 1,
                            Quantity =19,
                            UnitPrice= 1.99,                     

                        }
                    },
                OrderStatus = "DELIVEREd",
                PaymentType = "CARD",
                Total = 100

            }; 

            //Act
            var resultOrder = new OrderModel(DTO);
            var expectedDeliveryInfo = new AddressModel()
            {
                City = "Eindhoven",
                HouseNo = 1,
                StreeName = " Straatsburglan"
            };

            var expectedOrderItems = new CartModel()
            {
                Items = new List<ItemModel>()
                {
                    new ItemModel()
                    {
                        Product = new Logic.Products.Model.ProductModel()
                        {

                            ID = 1,
                            Name = "apple",
                            Price = 1.99
                        },
                        Quantity = 19
                    }
                }
            };
            //Assert

            Assert.AreEqual(1, resultOrder.ID);
            Assert.AreEqual(100, resultOrder.BonusPointsEarned);
            Assert.AreEqual(23, resultOrder.BonusPointsUsed);
            Assert.IsNotNull(resultOrder.UserModel);
            Assert.AreEqual(12, resultOrder.UserModel.ID);
            Assert.AreEqual("Bogdan", resultOrder.UserModel.Name);
            Assert.AreEqual(DateTime.MinValue, resultOrder.OrderDate);
            Assert.IsNotNull(resultOrder.DeliveryInfo);
            Assert.AreEqual(expectedDeliveryInfo, resultOrder.DeliveryInfo);
            Assert.IsNotNull(resultOrder.ShoppingCart);
            CollectionAssert.AreEqual(expectedOrderItems.Items, resultOrder.ShoppingCart.Items);
            Assert.AreEqual("DELIVEREd", resultOrder.OrderStatus);
            Assert.AreEqual(PaymentOptions.CARD, resultOrder.PaymentOption);
            Assert.AreEqual(100, resultOrder.Total);


        }
    }
}
