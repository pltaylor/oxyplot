﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IReportWriter.cs" company="OxyPlot">
//   The MIT License (MIT)
//   
//   Copyright (c) 2014 OxyPlot contributors
//   
//   Permission is hereby granted, free of charge, to any person obtaining a
//   copy of this software and associated documentation files (the
//   "Software"), to deal in the Software without restriction, including
//   without limitation the rights to use, copy, modify, merge, publish,
//   distribute, sublicense, and/or sell copies of the Software, and to
//   permit persons to whom the Software is furnished to do so, subject to
//   the following conditions:
//   
//   The above copyright notice and this permission notice shall be included
//   in all copies or substantial portions of the Software.
//   
//   THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS
//   OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
//   MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
//   IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
//   CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
//   TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
//   SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// </copyright>
// <summary>
//   Specifies functionality to write <see cref="Report" /> objects.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OxyPlot.Reporting
{
    /// <summary>
    /// Specifies functionality to write <see cref="Report" /> objects.
    /// </summary>
    public interface IReportWriter
    {
        /// <summary>
        /// Writes the specified drawing.
        /// </summary>
        /// <param name="drawing">The drawing.</param>
        void WriteDrawing(DrawingFigure drawing);

        /// <summary>
        /// Writes the specified equation.
        /// </summary>
        /// <param name="equation">The equation.</param>
        void WriteEquation(Equation equation);

        /// <summary>
        /// Writes the specified header.
        /// </summary>
        /// <param name="header">The header.</param>
        void WriteHeader(Header header);

        /// <summary>
        /// Writes the specified image.
        /// </summary>
        /// <param name="image">The image.</param>
        void WriteImage(Image image);

        /// <summary>
        /// Writes the specified paragraph.
        /// </summary>
        /// <param name="paragraph">The paragraph.</param>
        void WriteParagraph(Paragraph paragraph);

        /// <summary>
        /// Writes the specified plot.
        /// </summary>
        /// <param name="plot">The plot.</param>
        void WritePlot(PlotFigure plot);

        /// <summary>
        /// Writes the specified report with the specified style.
        /// </summary>
        /// <param name="report">The report.</param>
        /// <param name="reportStyle">The style.</param>
        void WriteReport(Report report, ReportStyle reportStyle);

        /// <summary>
        /// Writes the specified table.
        /// </summary>
        /// <param name="table">The table.</param>
        void WriteTable(Table table);
    }
}