using System;
using UnityEngine;

public class TryCatchFinally : MonoBehaviour
{
    private void Start()
    {
        try
        {
            // int a = 0;
            // int b = 1 / a;
            Player player = new Player();
            player.TestFunction();
            Debug.Log("Code Monkey!");
        }
        // catch (DivideByZeroException)
        // {
        //     Debug.Log("DivideByZeroException");
        // }
        // catch (Exception exception) when (exception is DivideByZeroException)
        // {
        //     Debug.Log(exception.Message + " " + exception.StackTrace);
        // }
        // catch (DivideByZeroException)
        // {
        // }
        catch (Exception exception)
        {
            Debug.Log(exception.Message + " " + exception.StackTrace);
            // return;
            throw;
        }
        finally
        {
            Debug.Log("Finally!");
        }
        Debug.Log("Hello there!");
        
    }

    private class Player
    {
        public class InvalidPlayerNameException : Exception
        {
        }
        
        public void TestFunction()
        {
            // throw new Exception("Player exception");
            throw new InvalidPlayerNameException();
        }
    }
}
