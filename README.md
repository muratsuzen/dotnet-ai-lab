# .NET AI Architect Laboratory 🚀

**The .NET AI Architect Laboratory is a strategic blueprint for designing, orchestrating, and scaling model-agnostic AI ecosystems.** This repository focuses on building robust architectural substrates where LLMs are treated as pluggable engines rather than hardcoded dependencies.

## 🎯 Core Philosophy
- **Provider Agnosticism:** Building a "Master Gateway" that can switch between **Gemini, OpenAI, Anthropic, and Local LLMs** with zero breaking changes.
- **Type Safety:** Enforcing strict data contracts (C# Classes) regardless of which model provides the response.
- **Abstraction-First:** Mastering `Microsoft.Extensions.AI` to decouple logic from specific providers.

---

## 🏗️ Technical Stack
- **Framework:** .NET 10 (Minimal APIs)
- **AI Abstraction:** `Microsoft.Extensions.AI`
- **Orchestration:** Microsoft Semantic Kernel
- **Active Engine:** Gemini 2.5 Flash (Phase 1 Reference)
- **Upcoming Engines:** Claude 3.5 Sonnet, GPT-4o, Llama 3.1 (Ollama)

---

## 🗺️ The Roadmap

### 🧱 Phase 1: Foundations & Multi-Model Abstraction (In Progress)
Focusing on the backend "Brain" and ensuring provider-independence.
- [x] **Enterprise Setup (Gemini):** Connectivity via Google Vertex AI & IAM.
- [x] **Secure Configuration:** Decoupled environment management.
- [ ] **Structured Output:** Universal JSON mapping to C# classes (The "Type-Safe" core).
- [ ] **Model Agnosticism:** Full implementation of `IChatClient` to support Claude/GPT.
- [ ] **API Gateway:** A clean Minimal API acting as the central intelligence hub.

### 🏗️ Phase 2: Action & UI Integration
Making AI "do things" and visualizing the results.
- [ ] **Orchestration:** Native C# Plugin development via Semantic Kernel.
- [ ] **Function Calling:** Designing reliable tool-use patterns.
- [ ] **Architecture Dashboard:** Introducing **Angular 19** to visualize model performance and outputs.

### 💾 Phase 3: Enterprise Memory (RAG)
- [ ] Vector Database Integration (PostgreSQL/pgvector).
- [ ] Semantic Retrieval optimization across different models.

### 🤖 Phase 4: Autonomous Agents & MCP
- [ ] Building custom MCP Servers in C#.
- [ ] Multi-agent workflow design.

---

## 🚀 How to Start
1. **Clone the Repo:** `git clone https://github.com/muratsuzen/dotnet-ai-lab.git`
2. **Navigate to the Lab:** `cd Phase1-LLM-Foundations/AI.Architect.Gateway`
3. **Setup Credentials:** Place `vertex-key.json` in the root and update `appsettings.json`.
4. **Run the API:** `dotnet run`

---
