using System;
using System.Threading.Tasks;
using UnityEngine;

public class AsyncAwaitTask : MonoBehaviour
{
    private static string serverReturnData;
    
    private async void Start()
    {
        string serverReturnData = await ContactWebServer();
        Debug.Log(serverReturnData);
        
        // Task task = ContactWebServer();

        // while (true)
        // {
        //     // task.Wait();
        //     if (task.IsCompleted)
        //     {
        //         int dataLength = serverReturnData.Length;
        //         Debug.Log(dataLength);
        //     }
        // }
        // await ContactWebServer();
        //
        // int dataLength = serverReturnData.Length;
        // Debug.Log(dataLength);

        // await CookEggs();
        // await CookBacon();
        // await MakeToast();
        
        Task eggsTask = CookEggs();
        Task baconTask = CookBacon();
        Task toastTask = MakeToast();

        await Task.WhenAll(eggsTask, baconTask, toastTask);
        Debug.Log("Breakfast done!");
    }

    // public static void ContactWebServer()
    public static async Task<string> ContactWebServer()
    {
        Debug.Log("Contacting server...");
        // Task.Delay(3000);
        await Task.Delay(3000);
        // serverReturnData = "Data";
        Debug.Log("Got response!");
        return "Data";
    }

    public static async Task CookEggs()
    {
        Debug.Log("Cooking eggs...");
        await Task.Delay(3000);
        Debug.Log("Eggs done!");
    }

    public static async Task CookBacon()
    {
        Debug.Log("Cooking bacon...");
        await Task.Delay(4000);
        Debug.Log("Bacon done!");
    }

    public static async Task MakeToast()
    {
        Debug.Log("Making toast...");
        await Task.Delay(1000);
        Debug.Log("Toast done!");
    }
}
