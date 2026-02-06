using System;
using System.IO;
using UnityEngine;

public class UsingIDisposable : MonoBehaviour
{
    private void Start()
    {
        // FileStream fileStream = File.Open("myFile.txt", FileMode.Open);
        // fileStream.Read(new Span<byte>());
        // fileStream.Dispose();
        // using (FileStream fileStream = File.Open("myFile.txt", FileMode.Open))
        // {
        //     fileStream.Read(new Span<byte>());
        // }
        
        using (SaveSystem saveSystem = new SaveSystem())
        {
            saveSystem.SavePlayerData();
            saveSystem.SaveObjectData();
        }
    }

    private class SaveSystem : IDisposable
    {
        private FileStream fileStream;

        public SaveSystem()
        {
            fileStream = File.Open("saveFile.save", FileMode.Open);
        }

        public void SavePlayerData()
        {
            // fileStream
        }

        public void SaveObjectData()
        {
            // fileStream
        }
        
        public void Dispose()
        {
            // Debug.Log("Dispose");
            fileStream.Dispose();
        }

        // 析构函数 GC回收前执行清理
        ~SaveSystem()
        {
            Dispose();
        }
    }
}
