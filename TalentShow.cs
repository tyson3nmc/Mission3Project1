using System;
using FinchAPI;
class Program
{
static void Main()
{
Finch myFinch = new Finch();
myFinch.connect();
myFinch.noteOn(250);
myFinch.wait(500);
myFinch.noteOff();
myFinch.wait(100);
myFinch.noteOn(250);
myFinch.wait(500);
myFinch.noteOff();
myFinch.wait(100);
myFinch.noteOn(270);
myFinch.wait(500);
myFinch.noteOff();
myFinch.wait(100);
myFinch.noteOn(250);
myFinch.wait(500);
myFinch.noteOff();
myFinch.wait(100);
myFinch.noteOn(300);
myFinch.wait(500);
myFinch.noteOff();
myFinch.wait(100);
myFinch.noteOn(290);
myFinch.wait(500);
myFinch.noteOff();
myFinch.wait(500);
myFinch.noteOn(250);
myFinch.wait(500);
myFinch.noteOff();
myFinch.wait(100);
myFinch.noteOn(250);
myFinch.wait(500);
myFinch.noteOff();
myFinch.wait(100);
myFinch.noteOn(270);
myFinch.wait(500);
myFinch.noteOff();
myFinch.wait(100);
myFinch.noteOn(250);
myFinch.wait(500);
myFinch.noteOff();
myFinch.wait(100);
myFinch.noteOn(320);
myFinch.wait(500);
myFinch.noteOff();
myFinch.wait(100);
myFinch.noteOn(300);
myFinch.wait(500);
myFinch.noteOff();
myFinch.wait(500);
myFinch.noteOn(250);
myFinch.wait(500);
myFinch.noteOff();
myFinch.wait(100);
myFinch.noteOn(250);
myFinch.wait(100);
myFinch.noteOff();
myFinch.wait(100);
myFinch.noteOn(500);
myFinch.wait(500);
myFinch.noteOff();
myFinch.wait(100);
myFinch.noteOn(440);
myFinch.wait(500);
myFinch.noteOff();
myFinch.wait(100);
myFinch.noteOn(300);
myFinch.wait(500);
myFinch.noteOff();
myFinch.wait(100);
myFinch.noteOn(290);
myFinch.wait(500);
myFinch.noteOff();
myFinch.wait(100);
myFinch.noteOn(270);
myFinch.wait(500);
myFinch.noteOff();
myFinch.wait(500);
myFinch.noteOn(460);
myFinch.wait(500);
myFinch.noteOff();
myFinch.wait(100);
myFinch.noteOn(460);
myFinch.wait(100);
myFinch.noteOff();
myFinch.wait(100);
myFinch.noteOn(440);
myFinch.wait(500);
myFinch.noteOff();
myFinch.wait(100);
myFinch.noteOn(300);
myFinch.wait(500);
myFinch.noteOff();
myFinch.wait(100);
myFinch.noteOn(320);
myFinch.wait(500);
myFinch.noteOff();
myFinch.wait(100);
myFinch.noteOn(300);
myFinch.wait(1000);
myFinch.noteOff();
myFinch.disConnect();
}
}
