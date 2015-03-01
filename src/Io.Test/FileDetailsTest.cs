using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Extension;
using NUnit.Framework;

namespace Io.Test
{
    [TestFixture]
    public class FileDetailsTest
    {
        private string[] _files;
        private Dictionary<string, FileDetails> _fileDetailsDictionary;

        [SetUp]
        public void BeforeEach()
        {
            _files = Directory.GetFiles(Environment.CurrentDirectory);
            _fileDetailsDictionary = _files
                .ToDictionary(f => f, f => new FileDetails(f));
        }

        [Test]
        public void FilenamesAreExtractedCorrectly()
        {
            var fileDictionary = _files.ToDictionary(f => f, Path.GetFileName);

            _files
                .ForEach(f => Assert.That(
                    _fileDetailsDictionary[f].Filename,
                    Is.EqualTo(fileDictionary[f])));
        }

        [Test]
        public void LastModifiedTimesAreExtractedCorrectly()
        {
            var fileDictionary = _files.ToDictionary(f => f, f => new FileInfo(f).LastWriteTimeUtc);

            _files
                .ForEach(f => Assert.That(
                    _fileDetailsDictionary[f].LastModified,
                    Is.EqualTo(fileDictionary[f])));
        }
    }
}