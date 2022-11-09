using System;
using System.Threading.Tasks;

namespace Asynchronous_programming
{
    internal class Program
    {

        static async Task Main(string[] args)
        {
            //Asynchronous programming with async and await.

            Juice juice = new Juice();
            Console.WriteLine("Juice is ready");

           
            var toastTask = MakeToastWithButterAndJamAsync();
            var sandwitchTask = MakingSandwitchAsync();
            var pizzaTask = MakingPizzaAsync();

            var toast = await toastTask;
            Console.WriteLine(toast.GetType().Name + " are ready");
            var sandwitch = await sandwitchTask;
            Console.WriteLine(sandwitch.GetType().Name + " are ready");
            var pizza = await pizzaTask;
            Console.WriteLine(pizza.GetType().Name + " are ready");     

            Console.WriteLine("Breakfast is ready");
        }

        private static Juice PourOJ()
        {
            Console.WriteLine("Pouring orange juice");
            return new Juice();
        }

        private static async Task<Toast> MakingToastAsync()
        {
            Console.WriteLine("Start toasting");
            await Task.Delay(5000);
            Console.WriteLine("Toast prepared");
            return new Toast();
        }

        private static Jams ApplyJam()
        {
            Console.WriteLine("Applying jams");
            return new Jams();
        }

        private static Butter ApplyButter()
        {
            Console.WriteLine("Applying butter");
            return new Butter();
        }

        private static async Task<Sandwitch> MakingSandwitchAsync()
        {
            Console.WriteLine("Start preparing Sandwitch");
            await Task.Delay(5000);
            Console.WriteLine("Sandwitch prepared");
            return new Sandwitch();
        }

        private static async Task<Pizza> MakingPizzaAsync()
        {
            Console.WriteLine("Start preparing Pizza");
            await Task.Delay(5000);
            Console.WriteLine("Pizza prepared");
            return new Pizza();
        }

        static async Task<Toast> MakeToastWithButterAndJamAsync()
        {
            var toast = await MakingToastAsync();
            ApplyButter();
            ApplyJam();
            return toast;
        }
    }



    internal class Juice { }
    internal class Toast { }
    internal class Jams { }
    internal class Butter { }
    internal class Sandwitch { }
    internal class Pizza { }
}
