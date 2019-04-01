using DP_Cars;
using System;
using Unity;
using Unity.Injection;

namespace DependencyInjection
{
    class Program
    {
        
        static void Main(string[] args)
        {

            /*EventLog writer = new EventLog();
            EmailSender sender = new EmailSender();
            AppPoolWatcher watcher = new AppPoolWatcher();
            watcher.Notify(writer, "IIS przestał odpowiadać");
            //watcher.Notify(sender, "Wysyłanie wiadomości do Admina.");*/
            TestMCUnit();
        }
        static void TestMCUnit()
        {
            IUnityContainer container = new UnityContainer();
            
            // container every time creates new object when we will use container.Resole<ICar>()
            container.RegisterType<ICar, BMW>();

            // Register Car Type
            container.RegisterType<ICar, Bugatti>("Sport Car");

            //Register Driver Type
            //container.Resolve("Sport Car") returns Bugatti object
            container.RegisterType<Driver>("Sport Car Driver", new InjectionConstructor(container.Resolve<ICar>("Sport Car")));

            //inject BMW 
            Driver driver = container.Resolve<Driver>();
            driver.RunCar();

            //inject Bugatti
            Driver driver2 = container.Resolve<Driver>("Sport Car Driver");
            driver2.RunCar();

            //We can register new instance of the object. Container will not create new instance
            ICar bugatti = new Bugatti();

            //Here we creates new instant instance
            IUnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterInstance<ICar>(bugatti);

            Driver driverBug = unityContainer.Resolve<Driver>();
            driverBug.RunCar();
            driverBug.RunCar();

            //Bugatti is not depends on driver
            Driver driverBug2 = unityContainer.Resolve<Driver>();

            //Here car drove 3 miles, not one. 
            driverBug2.RunCar();
        }
    }
}
