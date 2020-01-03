using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace YYNGE.DotNetCompiler
{
    public sealed class YYModule
    {
        private string Path { get; }
        public byte[] Binary { get; private set; }

        // https://webassembly.github.io/spec/core/binary/modules.html#binary-module
        private static readonly byte[] magicModuleHeader = new byte[] { 0x00, 0x61, 0x73, 0x6d };
        private static readonly byte[] moduleVersion = new byte[] { 0x01, 0x00, 0x00, 0x00 };

        public YYModule(string path)
        {
            Path = path;
        }

        public async Task CompileAsync()
        {
            //init empty module
            using (var memoryStream = new MemoryStream())
            using (var binaryWriter = new BinaryWriter(memoryStream))
            {
                binaryWriter.Write(magicModuleHeader);
                binaryWriter.Write(moduleVersion);

                //compile yym file to wasm

                //add wasm to module

                await memoryStream.FlushAsync();
                Binary = memoryStream.GetBuffer();
            }
        }

        //TODO: SaveAsWasmFile method
    }
}
