
# Excel Payment Processing

This repository contains a sample ASP.NET Core application that processes Excel files to read payment data and displays it in a paginated format. The application uses EPPlus to read Excel files and provides a web interface for file uploads and data visualization.
## Project Structure

- Controllers/ExelController.cs: Handles file uploads and processes the Excel files using ExelService.
- Services/ExelService.cs: Contains the logic to read payment data from Excel files and process it.
- Models/Payment.cs: Defines the structure of payment data.
- Views/Exel/Index.cshtml: Provides the UI for file upload.
- Views/Exel/Results.cshtml: Displays the processed payment data in a tabbed and paginated format.

## Technologies used

- ASP.NET Core: A cross-platform, high-performance framework for building modern, cloud-based, and internet-connected applications.
- EPPlus: A .NET library that reads and writes Excel files using the Open Office XML format (xlsx).
- Bootstrap: A popular CSS framework for developing responsive and mobile-first websites.
- C#: The programming language used for backend logic.
- HTML/CSS/JavaScript: Technologies used for building the frontend of the web application.

## Sample Files
The sampleExel folder contains sample Excel files for testing:

1. Empty File

- Filename: empty.xlsx
- Description: An empty Excel file with no data.
2. File with 100 Entries and 2 Payment Methods

- Filename: 100_entries_2_methods.xlsx
- Description: An Excel file containing 100 payment entries with 2 distinct payment methods.
3. File with 100 Entries and 4 Payment Methods

- Filename: 100_entries_4_methods.xlsx
- Description: An Excel file containing 100 payment entries with 4 distinct payment methods.
4. File with 200 Entries and 2 Payment Methods

- Filename: 200_entries_2_methods.xlsx
- Description: An Excel file containing 200 payment entries with 2 distinct payment methods.
# Getting Started

## Prerequisites

- .NET Core SDK 6.0 or later
- EPPlus NuGet package for handling Excel files

## Installation

1. Clone the repository:

```bash
  git clone https://github.com/SkionnPro/exel_reader.git
  cd exel_reader
```
2. Restore Dependencies

```bash
  dotnet restore
```
3. Run the Application

```bash
  dotnet run --project exel_reader.csproj
```
4. Navigate to the Application
- Open your web browser and go to http://localhost:5004 (or the localhost on which the project is currently running) to see the application in action.

## Usage

1. Upload an Excel File

- Go to the "Upload Excel File" page.
- Select one of the sample Excel files or your own file.
- Click "Upload" to process the file.
2. View Payment Data

- After uploading, you will be redirected to the "Payment Expenditures" page.
- The data will be displayed in a tabbed interface, with each tab representing a different payment method.
- Data is paginated for better readability.
## Contributing

Contributions are welcome! Please follow the guidelines below:

- Fork the repository.
- Create a new branch for your feature or bug fix.
- Make your changes.
- Submit a pull request with a description of your changes.
## License

This project is licensed under the MIT License - see the [MIT](https://choosealicense.com/licenses/mit/) file for details.
## contact

For questions or feedback, please reach out to work.anshum@gmail.com.

