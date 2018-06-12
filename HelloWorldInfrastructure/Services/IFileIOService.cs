﻿
namespace HelloWorldInfrastructure.Services
{
    /// <summary>
    ///     Service for file IO
    /// </summary>
    public interface IFileIOService
    {
        /// <summary>
        ///     Reads the specified file
        /// </summary>
        /// <param name="filePath">File path</param>
        /// <returns>The contents of the file</returns>
        string ReadFile(string filePath);
    }
}