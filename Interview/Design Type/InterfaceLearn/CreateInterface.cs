using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Design_Type.InterfaceLearn
{

    public interface ICar    
    {

        void Drive();
        void Stop();

        void Navigate();
    }


    public interface IElectricity {

        void Charge();
        void DisCharge();
    }


    public sealed class ElectricCar : ICar, IElectricity
    {
        void IElectricity.Charge()
        {
            throw new NotImplementedException();
        }

        void IElectricity.DisCharge()
        {
            throw new NotImplementedException();
        }

        void ICar.Drive()
        {
            throw new NotImplementedException();
        }

        void ICar.Navigate()
        {
            throw new NotImplementedException();
        }

        void ICar.Stop()
        {
            throw new NotImplementedException();
        }
    }


}
