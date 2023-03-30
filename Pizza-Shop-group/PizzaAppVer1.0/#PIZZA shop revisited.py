#PIZZA shop revisited

from collections import Counter
from email import header
from tokenize import Double
from flask import Flask, redirect, render_template, request
import csv
import os
from datetime import datetime

app = Flask(__name__)


pizzaName = {
    "1": "margherita",
    "2": "salami",
    "3": "funghi",
    "4": "diavoli",
    "5": "vegetarian"
}
orderId=1

#StartingPage
@app.route('/', methods=['GET'])
def index():
    return render_template('index.html')

#Authentication page that sends login data to the server
#supports login for cashier and chef 
@app.route('/login', methods=['POST'])
def login():
    cId = request.form['cId']
    if str(cId) == '1234':
        return render_template("OrderSelection.html")
    elif str(cId) == '4321':
        lines = readOrderCsv()
        return render_template("OrderStatus.html", lines = lines)
    else:
        error = "could not login with the given id!"
        return render_template("index.html", error=error)

@app.route('/logout', methods=['POST'])
def logout():
    return render_template("logOut.html")

#Adds a new order to the csv file with status "Processing"
@app.route('/submitOrder', methods=['POST'])
def order():
    global orderId, pizzaName
    pizzaId = request.form["pizzaId"]
    if os.path.isfile("pizzaData.csv"):
        fileMode='a+'
    else:
        fileMode='w'
    
    #TODO add to CSV
    with open("pizzaData.csv", fileMode, newline='') as file:
        writer = csv.writer(file)
        
        if fileMode == 'w' :
            row = ["Order ID", "Pizza Name", "Order Status"]
            writer.writerow(row)
        else: #appending to file
            file.seek(0) # go to start of file
            reader = csv.reader(file)
            rows = list(reader)
            print(rows)
            file.seek(0,2) # got to end of file
            orderId = len(rows)

        row = [orderId, pizzaName[pizzaId], "Processing"]
        writer.writerow(row)


    succes = "Your order for pizza has been accepted! \n Order number is " + str(orderId)
    return render_template("OrderSelection.html", success=succes)

#Reads the orders information from the csv file
@app.route('/orderStatus', methods=['GET'])
def order_status():
    lines = readOrderCsv()
    return render_template("OrderStatus.html", lines = lines)

def readOrderCsv():
    with open("pizzaData.csv", "r") as csvfile:
        csv_reader = csv.DictReader(csvfile)
        return list(csv_reader)


if __name__ == '__main__':
    app.run(debug=True)