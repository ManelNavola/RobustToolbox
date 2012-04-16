﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using ClientInterfaces.Resource;
using ClientServices.Helpers;
using GorgonLibrary;
using GorgonLibrary.Graphics;
using SS13.IoC;

namespace ClientServices.Player.PostProcessing
{
    public class BlurPostProcessingEffect : PostProcessingEffect
    {
        private GaussianBlur _gaussianBlur = new GaussianBlur(IoCManager.Resolve<IResourceManager>()); 
        public BlurPostProcessingEffect(float duration)
            :base(duration)
        {
        }

        public override void ProcessImage(RenderImage image)
        {
            if (_duration < 3)
                _gaussianBlur.SetRadius(3);
            else if (_duration < 10)
                _gaussianBlur.SetRadius(5);
            else 
                _gaussianBlur.SetRadius(7);
            
            _gaussianBlur.SetAmount(Math.Min(_duration / 2, 3f));
            _gaussianBlur.PerformGaussianBlur(image);
        }
    }
}
