Console.WriteLine($"[Main Thread] ID: {Environment.CurrentManagedThreadId}");

// Membuat thread baru
Thread worker = new Thread(ExecuteWorkerTask);
worker.Name = "CustomWorkerThread";

// Memulai eksekusi
worker.Start();

// Main thread melakukan pekerjaan lain
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"[Main] Bekerja... Step {i}");
    Thread.Sleep(300);
}

// Menunggu thread worker selesai
worker.Join();
Console.WriteLine("[Main] Selesai.");

static void ExecuteWorkerTask()
{
    Console.WriteLine($"[{Thread.CurrentThread.Name}] ID: {Environment.CurrentManagedThreadId} Dimulai.");
    Thread.Sleep(1000); // Simulasi kerja
    Console.WriteLine($"[{Thread.CurrentThread.Name}] Selesai.");
}