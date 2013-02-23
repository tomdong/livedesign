﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LiveDesign.Utilities
{
    public class UploadFile
    {
        Stream _data;
        string _fieldName;
        string _fileName;
        string _contentType;

        public UploadFile(Stream data, string fieldName, string fileName, string contentType)
        {
            _data = data;
            _fieldName = fieldName;
            _fileName = fileName;
            _contentType = contentType;
        }

        public UploadFile(string fileName, string fieldName, string contentType)
            : this(File.OpenRead(fileName), fieldName, Path.GetFileName(fileName), contentType)
        { }

        public UploadFile(string fileName)
            : this(fileName, null, "application/octet-stream")
        { }

        public Stream Data
        {
            get { return _data; }
            set { _data = value; }
        }

        public string FieldName
        {
            get { return _fieldName; }
            set { _fieldName = value; }
        }

        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        public string ContentType
        {
            get { return _contentType; }
            set { _contentType = value; }
        }
    }
}