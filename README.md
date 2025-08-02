# LoanAxis

**Loan Portfolio Management System – Demonstration Project**

LoanAxis is a demo-grade loan portfolio management system designed to showcase full-stack development skills for roles in financial institutions. 
Built with ASP.NET Core and Angular, this system models the core workflows of a modern loan management platform.

> ⚠️ **Disclaimer:** This system is a demo only. It is not intended for production use.

---

## 🌐 Live Demo

You can view the live demonstration hosted on **Azure App Service**:

🔗 [demo](loan-axis.tumpetech.com)

> This deployment is for demonstration purposes only. Data is mock or test-based, and security controls are basic.

---

## 📦 Project Structure

```

/LoanAxis
├── /backend      # ASP.NET Core Web API
├── /frontend     # Angular SPA
├── /docs         # Technical documentation
└── README.md

````

---

## 🎯 Purpose

- Showcase backend and frontend integration
- Simulate realistic financial workflows
- Demonstrate secure and maintainable design
- Present technical depth for software development roles

---

## 💡 Key Features

- Borrower registration and loan application flow
- Credit score simulation and loan approval
- Loan disbursement and repayment tracking
- Interest and penalty simulation
- Role-based user access (Admin, Officer, Client)
- RESTful API secured with JWT
- Angular UI with Material Design components

---

## 🛠️ Tech Stack

| Layer       | Technology         |
|-------------|--------------------|
| Backend     | ASP.NET Core 8     |
| Frontend    | Angular 17         |
| Database    | Postgres        |
| ORM         | Entity Framework   |
| Auth        | JWT Bearer Tokens  |
| Styling     | Angular Material   |
| Deployment  | Azure App Service  |

---

## ⚙️ Running Locally

### Prerequisites

- .NET 8 SDK
- Node.js + Angular CLI
- SQL Server or Docker
- Azure CLI (for deployment)

### Run Backend

```bash
cd backend/LoanAxis.Api
dotnet restore
dotnet ef database update
dotnet run
````

### Run Frontend

```bash
cd frontend
npm install
ng serve --open
```

---

## 🚀 Deployment Notes

This project is deployed as a demo to **Azure App Service** with:

* CI/CD pipeline using GitHub Actions
* App Service for frontend and backend APIs
* Azure SQL Database (optional, for real persistence)

> For security, no sensitive data is stored. Admin credentials for demo login are shared separately if needed.

---

## 📄 Documentation

See the `/docs` folder for:

* ER diagrams and user flows
* API structure
* Login credentials (demo users)
* Architectural overview

---

## ❗Important Disclaimer

This project is not intended for use in a real financial environment. It lacks production-grade security, compliance standards (e.g. PCI-DSS, KYC/AML), and legal readiness. Use of this code is at your own risk.

---

## 👤 Author

**Clifford Hepplethwaite**
Full-Stack Developer | Systems Administrator
📧 [Email](mailto:cliffordrh@egmail.com.com)
🔗 [LinkedIn](https://www.linkedin.com/in/clifford-hepplethwaite-2b5204348/)
🐦 [x.com](https://x.com/CHepplethwaite)

---

## 📃 License

This project is released under the MIT License.

```
