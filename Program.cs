﻿
// This file was auto-generated by ML.NET Model Builder. 

using MLModel1_ConsoleApp1;

// Create single instance of sample data from first line of dataset for model input
MLModel1.ModelInput sampleData = new MLModel1.ModelInput()
{
    Id = 51676F,
    Gender = @"Female",
    Age = 61F,
    Hypertension = 0F,
    Heart_disease = 0F,
    Work_type = @"Self-employed",
    Residence_type = @"Rural",
    Avg_glucose_level = 202.21F,
    Smoking_status = @"never smoked",
};

// Make a single prediction on the sample data and print results
var predictionResult = MLModel1.Predict(sampleData);

Console.WriteLine("Using model to make single prediction -- Comparing actual Stroke with predicted Stroke from sample data...\n\n");


Console.WriteLine($"Id: {51676F}");
Console.WriteLine($"Gender: {@"Female"}");
Console.WriteLine($"Age: {61F}");
Console.WriteLine($"Hypertension: {0F}");
Console.WriteLine($"Heart_disease: {0F}");
Console.WriteLine($"Work_type: {@"Self-employed"}");
Console.WriteLine($"Residence_type: {@"Rural"}");
Console.WriteLine($"Avg_glucose_level: {202.21F}");
Console.WriteLine($"Smoking_status: {@"never smoked"}");
Console.WriteLine($"Stroke: {1F}");


Console.WriteLine($"\n\nPredicted Stroke: {predictionResult.Score}\n\n");
Console.WriteLine("=============== End of process, hit any key to finish ===============");
Console.ReadKey();

