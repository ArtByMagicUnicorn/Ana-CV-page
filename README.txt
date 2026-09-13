# Ana CV

A modern, editable CV and portfolio website built for Ana M Gheorghe.

The project combines a public-facing Blazor WebAssembly site with a protected
administration interface, allowing CV content and media to be updated without
editing or redeploying the application code.

## Features

- Responsive public CV and portfolio
- Protected administration dashboard
- Editable profile information
- Experience management and ordering
- Skills, education, languages and certifications
- Beyond the Numbers personal section
- Profile and portfolio image uploads
- YouTube intro video support
- Persistent CV data stored in Azure Blob Storage
- Microsoft Entra ID authentication
- Role-based access to administrative features
- Azure Static Web Apps deployment

## Tech Stack

- Blazor WebAssembly
- .NET 10
- C#
- Azure Static Web Apps
- Azure Functions
- Azure Blob Storage
- Microsoft Entra ID
- GitHub Actions
- HTML / CSS

## Architecture

The solution is divided into three main parts:

### Frontend

A Blazor WebAssembly application responsible for both the public CV and
Ana Control Center, the protected administration interface.

### API

Azure Functions provide the backend API used to read and persist CV data
and upload media.

### Shared

Shared models are referenced by both the frontend and API, keeping the
client and backend data contracts aligned.

CV content is stored as JSON in a private Azure Blob Storage container.
Uploaded public media is stored separately and referenced by URL.

## Authentication

The public CV is available anonymously.

Administrative routes and write operations are protected using Microsoft
Entra ID authentication and a custom `cv_admin` role through Azure Static
Web Apps.

## Deployment

The application is deployed to Azure Static Web Apps through GitHub Actions.

The Blazor application is published separately before deployment, while
the Azure Functions project is built and deployed as the managed API.

Production configuration and storage credentials are provided through
Azure environment variables and are not stored in the repository.

## Project Structure

Ana-CV-page/
├── Ana CV page/              # Blazor WebAssembly frontend
├── Ana_CV_page.Shared/       # Shared models
├── api/                      # Azure Functions backend
├── .github/workflows/        # CI/CD
└── Ana CV page.slnx

## Status

The application is functional and deployed.

Current work focuses on user testing, final UI polish and documentation.

## About

This project was built as a custom CV platform rather than a static résumé
page. The goal was to give the owner control over her own content while
keeping the public experience lightweight and professional.