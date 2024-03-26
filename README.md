CompressionAlgorithm Project
============================

About The Project
-----------------

The `CompressionAlgorithm` project is a simple C# console application that demonstrates a basic string compression technique. Given a string, the application compresses it by using a count of repeated characters. For example, the string "aaabbc" would be compressed to "3a2b1c". This approach is often useful in situations where patterns of repeated characters are common, and it can help in reducing the size of the data if the string contains many such repetitions.

Architecture Overview
---------------------

The project is structured into a single C# console application that comprises the main entry point (`Program.cs`) and a static class (`Compressor`) responsible for the compression logic.

### Core Components

-   Program: The `Program` class contains the main entry point of the application. It provides a loop that continuously accepts input strings from the user, compresses them using the `Compressor` class, and displays the compressed string. It also handles user interactions for continuing or exiting the application.

-   Compressor: A static class that implements the string compression algorithm. It takes a string as input and returns a compressed version of the string. The compression logic checks for consecutive repeated characters and replaces the sequence with the count followed by the character itself.

How It Works
------------

1.  The user is prompted to enter a string.
2.  The `Compressor.Compress` method is called with the user's input.
3.  The method iterates over the string, counting consecutive repeated characters and forming a compressed string representation.
4.  The compressed string is displayed to the user. If the compressed string would be longer than the original string, the original string is returned instead.
5.  The user is asked if they wish to compress another string.

Getting Started
---------------

### Prerequisites

-   .NET SDK (The project is compatible with .NET Core and .NET Framework versions that support C#.)

### Running the Application

1.  Clone the repository to your local machine.
2.  Navigate to the project directory.
3.  Run the application using the `dotnet run` command from the terminal.

Usage
-----

Simply follow the on-screen prompts to enter strings you wish to compress. After each compression, you can choose to compress another string or exit the application.

Contributing
------------

Contributions are what make the open-source community such an amazing place to learn, inspire, and create. Any contributions you make to enhance the `CompressionAlgorithm` or to fix issues are greatly appreciated.

1.  Fork the Project.
2.  Create your Feature Branch (`git checkout -b feature/AmazingFeature`).
3.  Commit your Changes (`git commit -m 'Add some AmazingFeature'`).
4.  Push to the Branch (`git push origin feature/AmazingFeature`).
5.  Open a Pull Request.

License
-------

Distributed under the MIT License. See `LICENSE` file for more information.