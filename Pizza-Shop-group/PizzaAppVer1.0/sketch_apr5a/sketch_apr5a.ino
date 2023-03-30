#include "Arduino.h"

//Declaring global variables
  //Declare the variables for the pins
const int LDR_Pin = 2;
const int RedLED_Pin = 7;
const int Buzzer_Pin = 3;
 
  //Declare variables for time and threshold value
long int currentTime = 0;
long int lastDataRead = 0;
const int dataReadThreshold = 1000;
int lightLevel = 500;

//Starting the serialport and initializing the pins
void setup() {
  pinMode(LDR_Pin, INPUT);
  pinMode(RedLED_Pin, OUTPUT);
  pinMode(Buzzer_Pin, OUTPUT);
  Serial.begin(115200);
  Serial.setTimeout(50);
}

//Reading the lightLevel every time the threshold has been passed and passing this on over the serial port.
void loop() {
  currentTime = millis();
  if (currentTime - lastDataRead >= dataReadThreshold){
    lastDataRead = currentTime;
    lightLevel = analogRead(LDR_Pin);
    // for demo prps Serial.println(lightLevel);
    if (lightLevel <= 500){
      tone(Buzzer_Pin, 1000);
      Serial.println("Finished");
    } else if (lightLevel > 500) {
      noTone(Buzzer_Pin);
    }
  }
}
