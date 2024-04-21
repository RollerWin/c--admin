using System;
using System.Diagnostics;


try
{
    Console.WriteLine("Список запущенных процессов:");
    Process[] processes = Process.GetProcesses();

    foreach (var process in processes)
        Console.WriteLine($"ID: {process.Id}, Имя: {process.ProcessName}");

    Console.WriteLine("\nВведите ID процесса для завершения:");
    int processId = int.Parse(Console.ReadLine());

    Process processToKill = Process.GetProcessById(int.Parse(Console.ReadLine()));
    processToKill.Kill();

    Console.WriteLine($"Процесс с ID {processId} был успешно завершен.");
}
catch (FormatException)
{
    Console.WriteLine("Ошибка: введенное значение не является числом.");
}
catch (OverflowException)
{
    Console.WriteLine("Ошибка: введенное число слишком большое или слишком маленькое.");
}
catch (ArgumentException)
{
    Console.WriteLine("Ошибка: процесс с указанным ID не найден.");
}
catch (Exception ex)
{
    Console.WriteLine($"Произошла ошибка: {ex.Message}");
}

