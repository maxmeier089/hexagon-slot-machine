using DependencyInjection;
using Payment;
using SlotMachine;

Console.OutputEncoding = System.Text.Encoding.Unicode;

ISlotMachine slotMachine = SlotMachineFactory.CreateSlotMachine();

CoinSlotAndDispenser.Instance.InsertCoinTest(10.0m);


while (true)
{

    Console.WriteLine("Press Enter to pull lever. Type pay to get your money.");

    string? input = Console.ReadLine();

    if (input == string.Empty)
    {
        slotMachine.PullLever();

        Console.WriteLine("Spinning...\nPress Enter to release lever");
        Console.ReadLine();

        slotMachine.ReleaseLever();
    }
    else if (input == "pay")
    {
        slotMachine.Payout();
        break;
    }
}

Console.WriteLine("CU!");
Console.ReadLine();