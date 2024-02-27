# ImAnno - Image Annotator Tool
ImAnno is a tool to generate tags classification data for images. It's possible to create complex log strings to suit several pos-processing solutions in multiple languages. The software is also flexible enought to help with the image organization, being able to move any image you tagged to the output folder selected. 

Possibilities of use:

* Machine learning image labelling;
* Web development (image gallery);
* Flatenning folder tree structures;
* Organize images in multiple folders based on user configurations.

## How to use

### Path & Tags file configuration
Is mandatory to configure the input path, output path and the file containing the tags to use. Its possible to choose any folder for both paths, but take into consideration that the software will always ignore the images inside the output folder. If you set both input and output as the same path you may have a warning of empty images. If there's subfolders inside the input path, even if the path is the same of output, they will be considered normally.

**Tags File Content**

The tags file must have a specific format to properly work. The code will check the structure below:
```
category: tag1, tag2, tag3
category:tag1,tag2,tag3
category:   tag1, tag 2, new tag   3
...
```
Each category will be used to group tags in the annotator tool for better organization. Each tag between commas will be available at the execution to be applied on the images. If you set any category as `author`or `authors` the annotator will fill the author block with these information.

### Tags personalization

ImAnno has three personalizations for tags and authors: prefix, suffix and separator. You can remove the default data or set your own personal option. For the example tags `Blue, Medium, 300x200` see below how this configuration will be applied:

|Left|Right|Separator|Output|
|---|---|---|---|
|"|"|,|"Blue","Medium","300x200"|
|[|]|\\ |[Blue]\\[Medium]\\[300x200]|
|I am |!| And |I am Blue! And I am Medium! And I am 300x200!|

### Logs configuration

In addition to the tags personalization, it's also possible to personalize the log generation. Each `<word>` is a predefined placeholder for the applied tags. Check below some examples of the usage:

* Filename: `image_01.png`
* Author: `"Picasso"`
* Tags: `"blue","sad","sentimental"` 

|Log pattern| output |
|---|---|
|Processed: \<filename> Tags: \<tags> Authors: \<authors>|Processed: image_01.png Tags: "blue","sad","sentimental" Authors: "Picasso"|
|string list = [["\<filename>"],[\<tags>],[\<authors>]]|string list = [["image_01.png"]["blue","sad","sentimental"]["Picasso"]]|
|\<html><br>&emsp;\<div class="file"><br>&emsp;&emsp;\<img src="\<filename>"/><br>&emsp;&emsp;\<p>File: \<filename>\</p><br>&emsp;\</div><br>&emsp;\<span class="author">\<authors>\</span><br>&emsp;\<span class="tags">\<tags>\</span><br>\</html>|\<html><br>&emsp;\<div class="file"><br>&emsp;&emsp;\<img src="image_01.png"/><br>&emsp;&emsp;\<p>File: image_01.png\</p><br>&emsp;\</div><br>&emsp;\<span class="author">"Picasso"\</span><br>&emsp;\<span class="tags">"blue","sad","sentimental"\</span><br>\</html>|

### Extended options
It's also possible to choose between two aditional configurations: Move files and search subfolders. By default only the files inside the input folder itself will be loaded, but if you choose to search subfolders each subsequent subfolder images will be added to the process stack. Regarding the move option, by default the app will not move any image and will only generate a log file in the output folder. If you enable this option, every <u>tagged</u> image will be moved to the output folder selected. Skipped images will remain in the source paths.
Please note that if the output folder already have a file with the same name of the current file, the software will rename the file to be able to move, automatically and without any message.