using System;
using System.Collections.Generic;
using System.Text;

namespace oop-6214421017-w04
{
    class Room
    {
        private string roomCode;
        private string roomName;
        private int roomWidth;
        private int roomLength;
        private string roomType;
        private int arc = 2;
        public Room(string c,string n,int w,int h)
        {
            this.roomCode = c;
            this.roomName = n;
            this.roomWidth = w;
            this.roomLength = h;
        }
        public Room() { }
        public Room(string c)
        {
            this.roomCode = c;
        }
        public int Area(int w,int h)
        {
            return w * h;
        }
        public int Available(int w,int h)
        {
            return (w * h) / arc;
        }
        public string Getroom()
        {
            return  this.roomCode;
        }
        public override string ToString()
        {
            return "Room Code: "+this.roomCode+" Room Name: "+this.roomName+"\n Room Width: "+this.roomWidth+"\t Room Length: "+this.roomLength+"\n Room Area: "+this.Area(this.roomWidth,this.roomLength)+"\t Room available: "+this.Available(this.roomWidth,this.roomLength);
        }
    }
}
