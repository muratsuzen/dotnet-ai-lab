using System;
using System.Threading.Tasks;
using Google.GenAI;
using Microsoft.Extensions.Configuration;

public class GenerateContentSimpleText
{
    public static async Task Main()
    {
        // --- 0. CONFIGURATION SETUP ---
        var config = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        // Get settings from appsettings.json
        string projectId = config["Gemini:ProjectId"] ?? throw new Exception("ProjectId is missing!");
        string location = config["Gemini:Location"] ?? "us-central1";
        string modelId = config["Gemini:ModelId"] ?? "gemini-2.5-flash";

        // --- 1. AUTHENTICATION ---
        Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "vertex-key.json");

        // --- 2. INITIALIZATION ---
        // Now using dynamic settings from the configuration file
        var client = new Client(
            project: projectId,
            location: location,
            enterprise: true
        );

        Console.WriteLine($"🚀 [AI Architect Lab] Initializing {modelId} via Vertex AI...");
        Console.WriteLine($"💰 Project: {projectId} | Mode: Enterprise");

        try
        {
            // --- 3. EXECUTION ---
            var response = await client.Models.GenerateContentAsync(
                model: modelId,
                contents: "Why is the sky blue? Give a brief technical explanation."
            );

            // --- 4. OUTPUT ---
            Console.WriteLine("\n--- 🟢 RESPONSE ---");
            Console.WriteLine(response.Candidates[0].Content.Parts[0].Text);
            Console.WriteLine("\n✅ Analysis completed successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\n❌ [Runtime Error]: {ex.Message}");
        }
    }
}