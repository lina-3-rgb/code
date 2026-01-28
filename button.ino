int LED = 10; 
const int btn = 2;
int statusBtn = 0;

void setup()
{
  
  pinMode(LED, OUTPUT);
  pinMode(btn, INPUT);
}
void loop()
{
  statusBtn = digitalRead(btn);
  
  if(statusBtn == 1){
    digitalWrite(LED, HIGH);
  } else {
    digitalWrite(LED, LOW);
  }
}