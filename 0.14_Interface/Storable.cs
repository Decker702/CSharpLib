using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Interface//Is a contract, where you define the methods and properties that any implenting class must provide.
    //Interfaces typically begin with I, but didn't do it here.
{
    public enum ReturnStatus
    {
        OK,
        Fail
    };          

    public interface Storable //has to be public
    {
        void Write(object obj);
        String Read();
        ReturnStatus Status { get; set; }
    }
}
