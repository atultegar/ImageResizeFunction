using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ImageResizeFunction.Services
{
    public class ImageResizer : IImageResizer
    {
        public void Resize(Stream input, Stream output)
        {
            using (Image image = Image.Load(input))
            {
                image.Mutate(x => x.Resize(400, 0));
                image.Save(output, new JpegEncoder());
            }
        }
    }
}
