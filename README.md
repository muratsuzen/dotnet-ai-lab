# .NET AI Architect Laboratory 🚀

This repository documents my strategic journey from a Senior .NET Developer to an **AI Architect**. The focus is not on training models from scratch, but on **designing, orchestrating, and scaling** AI-driven enterprise solutions using the .NET ecosystem.

## 🎯 Core Philosophy
- **Abstraction over Implementation:** Using `Microsoft.Extensions.AI` to stay model-agnostic.
- **Type Safety:** Moving away from "string-based" AI responses to strongly-typed C# schemas.
- **Orchestration:** Leveraging **Semantic Kernel** to give AI autonomous capabilities.
- **Enterprise Grade:** Focus on RAG (Retrieval-Augmented Generation) and the Model Context Protocol (MCP).

---

## 🏗️ Technical Stack
- **Framework:** .NET 10
- **AI Abstraction:** `Microsoft.Extensions.AI`
- **Orchestration:** Microsoft Semantic Kernel
- **Vector Storage:** PostgreSQL with `pgvector` / Qdrant
- **Communication:** Model Context Protocol (MCP)
- **Frontend:** Angular 19+

---

## 🗺️ The Roadmap

### 🧱 Phase 1: LLM API Fundamentals & Type Safety (Current)
Integrating LLMs as "engines" via standard APIs while ensuring strict JSON outputs for seamless frontend integration.
- [x] Repository Setup
- [ ] Gemini 1.5 Flash/Pro Integration
- [ ] Implementing `IChatClient` for Model Agnosticism
- [ ] Structured Output Management (Strongly Typed Responses)

### 🏗️ Phase 2: .NET AI Orchestration
Transforming AI from a "chatbot" to an "action-taker" using Semantic Kernel and Function Calling.
- [ ] Native C# Plugin Development
- [ ] Intent Recognition and Tool Mapping
- [ ] Autonomous Process Orchestration

### 💾 Phase 3: Enterprise Memory (RAG)
Providing AI with secure access to corporate data (SQL, Logs, Docs) without retraining.
- [ ] Vector Database Implementation
- [ ] Context Management & Retrieval Optimization
- [ ] Building a Private Knowledge Base

### 🤖 Phase 4: Autonomous Agents & MCP
Building self-deciding agents and implementing the Anthropic **Model Context Protocol (MCP)** with C#.
- [ ] Agentic Workflow Design
- [ ] MCP Server implementation for SQL & File System access
- [ ] Claude Certified Architect Preparation

---

## 👨‍💻 Author
**Murat** *Senior Software Developer & IT Manager with 10+ years of experience in .NET & Angular.* *Focusing on the intersection of Enterprise Architecture and Generative AI.*

---

### 🚀 How to Start
```bash
# Clone the repository
git clone [https://github.com/muratsuzen/dotnet-ai-lab.git](https://github.com/muratsuzen/dotnet-ai-lab.git)

# Navigate to the first lab (Coming Soon)
cd Phase1-LLM-Foundations
dotnet run
