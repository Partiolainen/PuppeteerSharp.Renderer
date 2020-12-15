using PuppeteerSharp.RendererCli;
using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace PuppeteerSharp.RendererCliTests
{
    public class UnitTest1
    {
        [Fact]
        public void VersionShouldBeProcessed()
        {
            Version.TryParse(Program.Version.ToString(), out _);
        }

        [Fact]
        public async Task ConversionShouldWork()
        {
            var testFileName = "BasicTextFormated.html";
            var sourceHtmlFilePath = $"../../../TestInput/{testFileName}";
            var actualFilePath = Path.Combine(Path.GetTempPath(), $"Actual{testFileName}.pdf");

            await Program.Main(new[] { sourceHtmlFilePath, actualFilePath });

            Assert.True(File.Exists(actualFilePath));
        }
    }
}