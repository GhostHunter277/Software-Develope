using System;
using NUnit.Framework;

namespace OP_LAB_1
{ [TestFixture]
    
    public class Tests
    { 
        Squar Kvadrat=new Squar(new Point(1,1),new Point(5,5));
     

        [Test]
        public void Test1()
        {
            int wait = 16;
            int result = Kvadrat.Area();
            //int result = 16;
            
            Assert.AreEqual(wait,result);
            Console.WriteLine("snap1");
            Kvadrat.Print();
           
        }
        
        [Test]
        public void Test2()
        {
            int wait = 16;
            int result = Kvadrat.Perimetr();
            //int result = 16;
            Assert.AreEqual(wait,result);
            Kvadrat.Print();
        }
        
    }
}