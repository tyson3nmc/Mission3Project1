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

myFinch.disConnect();
}
}
