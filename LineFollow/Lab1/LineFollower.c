// Jayson Tilley


#include "F_cpu_lib.h"
#include <avr/io.h>
#include <util/delay.h>
#include "LCD_lib.h"
#include "Serial_lib2.h"
#include "Motor_PWM_lib.h"
#include "A2D_lib.h"
#include "tic_toc_lib.h"

uint8_t leftMotor = 0;
uint8_t rightMotor = 1;
uint8_t forward = 0;
uint8_t reverse = 1;

int main(void)
{
	DDRC |= 1 << PORTC2;
	
	char motion;
		
	LCD_init();
	USART_vInit();
	HBridgeInit();
	
	sei();
	
	LCDGoToPosition(1,1);
	LCDSendString("Hello World!");
	
	while(1)
	{
		motion = USART_vReceiveByte();
		
		switch(motion)
		{
			case 'Z':
			{
				LCDClearScreen();
				HBridgeCommand(leftMotor, 100, forward);
				HBridgeCommand(rightMotor, 20, forward);
				LCDGoToPosition(1,1);
				LCDSendString("Turning Fast Left");
				break;
			}
			case 'X':
			{	
				LCDClearScreen();
				HBridgeCommand(leftMotor, 80, forward);
				HBridgeCommand(rightMotor, 30, forward);
				LCDGoToPosition(1,1);
				LCDSendString("Turning Medium Left"); 
				break;
			}
			case 'C':
			{
				LCDClearScreen();
				HBridgeCommand(leftMotor, 80, forward);
				HBridgeCommand(rightMotor, 50, forward);
				LCDGoToPosition(1,1);
				LCDSendString("Turning Slow Left");
				break;
			}
			case 'V':
			{
				LCDClearScreen();
				HBridgeCommand(leftMotor, 80, forward);
				HBridgeCommand(rightMotor, 80, forward);
				LCDGoToPosition(1,1);
				LCDSendString("Going Forward");
				break;
			}
			case 'B':
			{
				LCDClearScreen();
				HBridgeCommand(leftMotor, 50, forward);
				HBridgeCommand(rightMotor, 80, forward);
				LCDGoToPosition(1,1);
				LCDSendString("Turning Slow Right");
				break;
			}
			case 'N':
			{
				LCDClearScreen();
				HBridgeCommand(leftMotor, 30, forward);
				HBridgeCommand(rightMotor, 80, forward);
				LCDGoToPosition(1,1);
				LCDSendString("Turning Medium Right");
				break;
			}
			case 'M':
			{
				LCDClearScreen();
				HBridgeCommand(leftMotor, 20, forward);
				HBridgeCommand(rightMotor, 100, forward);
				LCDGoToPosition(1,1);
				LCDSendString("Turning Fast Right");
				break;
			}
			case 'S':
			{
				LCDClearScreen();
				HBridgeCommand(leftMotor, 0, forward);
				HBridgeCommand(rightMotor, 0, forward);
				LCDGoToPosition(1,1);
				LCDSendString("Stopping");
				break;
			}
		}
	}
}

