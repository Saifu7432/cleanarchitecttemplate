﻿using CleanArchitecture.Core.Interfaces;
using Microsoft.Extensions.Logging;
using System;

namespace CleanArchitecture.Infrastructure;

/// <summary>
/// An ILoggerAdapter implementation that uses Microsoft.Extensions.Logging
/// </summary>
/// <typeparam name="T"></typeparam>
public class LoggerAdapter<T>(ILogger<T> _logger) : ILoggerAdapter<T>
{
  public void LogError(Exception ex, string message, params object[] args)
  {
    _logger.LogError(ex, message, args);
  }

  public void LogInformation(string message, params object[] args)
  {
    _logger.LogInformation(message, args);
  }
}
