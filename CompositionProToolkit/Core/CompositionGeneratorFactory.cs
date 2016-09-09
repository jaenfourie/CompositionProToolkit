﻿// Copyright (c) 2016 Ratish Philip 
//
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal 
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is 
// furnished to do so, subject to the following conditions: 
// 
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software. 
// 
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE. 
//
// This file is part of the CompositionProToolkit project: 
// https://github.com/ratishphilip/CompositionProToolkit
//
// CompositionProToolkit v0.4.6
// 

using Windows.UI.Composition;

namespace CompositionProToolkit
{
    /// <summary>
    /// Factory class to instantiate the CompositionGenerator
    /// </summary>
    public static class CompositionGeneratorFactory
    {
        /// <summary>
        /// Instantiates a CompositionGenerator object
        /// </summary>
        /// <param name="compositor">Compositor</param>
        /// <param name="useSharedCanvasDevice">Whether to use a shared CanvasDevice or to create a new one.</param>
        /// <param name="useSoftwareRenderer">Whether to use Software Renderer when creating a new CanvasDevice.</param>
        /// <returns>ICompositionGenerator</returns>
        public static ICompositionGenerator GetCompositionGenerator(Compositor compositor, 
            bool useSharedCanvasDevice = true, bool useSoftwareRenderer = false)
        {
            return new CompositionGenerator(compositor, useSharedCanvasDevice, useSoftwareRenderer);
        }

        /// <summary>
        /// Instantiates a CompositionGenerator object
        /// </summary>
        /// <param name="graphicsDevice">Composition Graphics Device</param>
        /// <returns>ICompositionGenerator</returns>
        public static ICompositionGenerator GetCompositionGenerator(CompositionGraphicsDevice graphicsDevice)
        {
            return new CompositionGenerator(graphicsDevice);
        }
    }
}