int led1 = 2;
int led2 = 3;
int led3 = 4;
int led4 = 5;
int led5 = 6;
int led6 = 7; 
int led7 = 8;
int led8 = 9;
int red = 10; 
int yellow = 11;
int green = 12;


void setup() {  
    pinMode(11, OUTPUT);
    pinMode(12, OUTPUT);
    pinMode(10, OUTPUT);
    pinMode(2, OUTPUT);  
    pinMode(3, OUTPUT);
    pinMode(4, OUTPUT); 
    pinMode(5, OUTPUT);  
    pinMode(6, OUTPUT);
    pinMode(7, OUTPUT); 
    pinMode(8, OUTPUT);  
    pinMode(9, OUTPUT); 
}  

void loop() {  
  digitalWrite(red, HIGH);
    digitalWrite(led3, HIGH); 
    digitalWrite(led2, HIGH); 
    digitalWrite(led5, HIGH); 
    digitalWrite(led6, HIGH); 
    digitalWrite(led7, HIGH); 
    digitalWrite(led8, HIGH); //9
    delay(1000);
    digitalWrite(led4, HIGH);  //8 
    delay(1000);
    digitalWrite(led4, LOW);
    digitalWrite(led3, LOW);
    digitalWrite(led5, LOW);
    digitalWrite(led6, LOW);//7
    delay(1000);
    
    digitalWrite(led8, LOW);
    digitalWrite(led6, HIGH); 
    digitalWrite(led3, HIGH); 
    digitalWrite(led2, HIGH); 
    digitalWrite(led5, HIGH); 
    digitalWrite(led4, HIGH);//6
    delay(1000);
    digitalWrite(led4, LOW);//5
    delay(1000);
    digitalWrite(led7, LOW);
    digitalWrite(led3, LOW);
    digitalWrite(led8, HIGH);//4
    delay(1000);
    digitalWrite(led3, HIGH); 
    digitalWrite(led6, LOW);
    digitalWrite(led7, HIGH);//3
    delay(1000);
    digitalWrite(led2, LOW);
    digitalWrite(led3, HIGH); //2
    delay(1000);
    digitalWrite(led7, LOW);
    digitalWrite(led5, LOW);
    digitalWrite(led4, LOW);
    digitalWrite(led3, LOW);
    digitalWrite(led2, HIGH);//1
    delay(1000);
     digitalWrite(red, HIGH);
    delay(2000);
    digitalWrite(yellow, HIGH); 
    delay(1000);
    digitalWrite(green, HIGH); 
    delay(2000);
    
    
    
    
    
    
    
    
    
    
   
     
    
    
}  
