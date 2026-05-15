# .NET AI Architect Laboratory 🚀

This repository is a hands-on **Learning Laboratory** documenting my strategic journey from a Senior .NET Developer to an **AI Architect**.

The core objective of this lab is to move beyond simple chatbot implementations and master the design, orchestration, and scaling of enterprise-grade AI systems where the **LLM is a pluggable engine**, not a hardcoded dependency.

## 🎯 Core Philosophy

- **Provider Agnosticism:** Designing architectures that can switch between **Gemini, OpenAI, Anthropic, or Local LLMs (Ollama)** with minimal code changes.
- **Abstraction-First:** Leveraging `Microsoft.Extensions.AI` to decouple application logic from specific LLM providers.
- **Type Safety:** Enforcing strict data contracts between AI engines and .NET applications using **Strongly-Typed Schemas** (JSON Mapping).

---

## 🏗️ Technical Stack

- **Framework:** .NET 10 (Minimal APIs)
- **AI Abstraction:** `Microsoft.Extensions.AI`
- **Orchestration:** Microsoft Semantic Kernel
- **Reference Engine:** Gemini 2.5 Flash (via Vertex AI Enterprise)
- **Planned Engines:** Claude 3.5 Sonnet, GPT-4o, Llama 3.1
- **Frontend:** Angular 19+ (Architecture Dashboard)

---

## 🗺️ The Roadmap

### 🧱 Phase 1: LLM Fundamentals & Abstraction (In Progress)

Establishing the core connectivity and data-flow patterns for a multi-model future.

- [x] **Enterprise Gateway:** Initial connectivity setup using Vertex AI as the reference provider.
- [x] **Secure Configuration:** Provider-independent secret management and environment setup.
- [ ] **Structured Output Management:** Mapping AI responses to C# Classes using JSON Schemas.
- [ ] **Implementing IChatClient:** Transitioning to a fully model-agnostic `Microsoft.Extensions.AI` architecture.
- [ ] **Universal AI Gateway:** A .NET Minimal API serving an Angular 19+ dashboard.

### 🏗️ Phase 2: .NET AI Orchestration

- [ ] Native C# Plugin Development for multi-model orchestration.
- [ ] Intent Recognition and Tool Mapping.
- [ ] Autonomous Process Orchestration via Semantic Kernel.

### 💾 Phase 3: Enterprise Memory (RAG)

- [ ] Vector Database Implementation (PostgreSQL/pgvector or Qdrant).
- [ ] Context Management & Retrieval Optimization.

### 🤖 Phase 4: Autonomous Agents & MCP

- [ ] Building self-deciding agents.
- [ ] Implementing the **Model Context Protocol (MCP)** with C#.

---

## 🚀 Current Lab Setup (Gemini/Vertex AI)

_While the architecture is designed to be agnostic, the current active lab utilizes Google Vertex AI for its enterprise stability._

1. **Clone & Configure:**

   ```bash
   git clone https://github.com/muratsuzen/dotnet-ai-lab.git

   ```

2. **Setup Credentials:**

Place your Google Cloud Service Account Key (vertex-key.json) in the root directory.

Update appsettings.json with your ProjectId.

3. **Run the Lab:**
   ```bash
   cd Phase1-LLM-Foundations/AI.Architect.Gateway
   dotnet run
   ```

## 💡 Architectural Vision: "The Model is Rented, the Context is Yours"

In the era of rapidly evolving AI, the model itself is a commodity. The true value lies in the Architectural Substrate that governs how data is retrieved, how context is managed, and how models are swapped based on task-specific performance. This laboratory is the blueprint for that future.
