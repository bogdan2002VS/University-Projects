import serial
import csv
import os

#Open serial port
ser = serial.Serial('COM3', 115200, timeout = 10)

#this is the header that is used in the csv file
header = ['Order ID','Pizza Name','Order Status']

#checks where the csv file is located
pizzFileName = os.path.join(os.path.dirname(__file__), 'pizzaData.csv')
while True:
    #checks if the arduino has sent anything over the serial port and reads said data
    if (ser.in_waiting > 0):
        data = ser.read_until(b'\n')
        print(data)
        #open the csv file and be able to read and write from the beginning
        with open(pizzFileName, "r+", newline='', encoding="UTF-8") as csvFile:
            reader = csv.DictReader(csvFile)
            writer = csv.writer(csvFile)
            lines = list(reader)
            #checks the last line with processing status and changed this to finished
            for line in lines:
                orderColumn = line.get('Order Status')
                if "Processing" in orderColumn and "Finished" in str(data):
                    line.update({'Order Status': "Finished"})
                    break
            #rewrites the csv file with the changed status
            csvFile.seek(0)
            writer.writerow(header)
            for line in lines:
                writer.writerow(line.values())   
            print(lines)              

    ##Order ID, Pizza name, Status
    ##Finished, new order, in progress, fullfilled