Directions:
Create a console application written in C# that does the following:

1) Scan a provided directory for PDF files that contain "_SPD COVER PAGE.PDF" in the filename.
2) Extract each page from the PDF file found, and append it to the corresponding "_SPD_" named file
3) Save out this new file using the naming convention "PLANID_00000.pdf"

Notes:
PLANID = All characters up to the first underscore (_) in the filename from 1.
00000 = Incrementing integer value starting with 1
Use the provided DLL for working with the PDF files:
http://www.dynamicpdf.com/Support/NET_Help_Library_16_12/#DynamicPDF%20Merger%20for%20.NET.html
Since I'm not providing a license key, it will watermark the created PDF files, which is fine for this demo.
