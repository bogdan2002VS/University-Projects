# Read Me for the Arduino Part of this project #

## What does the arduino do? ##

The Arduino reads the amount of light that hits the LDR sensor, it then uses that data to check if the light level is low enough when something is above it.
When this is the case, the arduino will send out something over the serial port which will be caught by the python code.
Currently this python code doesn't do anything with this data and we still have to have it change order status in a csv file.

## How to start the programs. ##
1. Upload the arduino part (sketch_apr5a) and make sure the serial monitor is closed.
2. Start the python code, in the terminal you should now be able to see when a pizza is ready.