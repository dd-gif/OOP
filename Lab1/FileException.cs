using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Lab1 {
  public class FileException : Exception {
    public FileException(string message) : base(message) {}
  }
  public class TypeException : Exception {
    public TypeException(string message) : base(message) {}
  }
  public class WrongNameException : Exception {
    public WrongNameException(string message) : base(message) {}
  }
}
