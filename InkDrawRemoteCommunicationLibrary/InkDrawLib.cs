using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkDrawRemoteCommunicationLibrary
{
    /// <summary>
    /// InkDraw S/W 원격명령 라이브러리
    /// </summary>
    public class InkDrawLib
    {
        #region Command
        /// <summary>
        /// Closes the active window. A new connect request is required afterwards.
        /// 활성화된 창을 닫기. 닫은 후에는 재요청시 새로 연결해야합니다.
        /// </summary>
        /// <returns></returns>
        public string CommandClose()
        {
            return "COMMAND:close#";
        }

        /// <summary>
        /// Search the database for <string>. If ‘J’ or ‘search’ is used, it will search the whole database
        /// .If ‘K’ or ‘fastsearch’ is used, it will search only in the first column.
        /// </summary>
        /// <param name="searchKeyword"></param>
        /// <returns></returns>
        public string CommandDatabaseSearch(string searchKeyword)
        {
            return string.Format("COMMAND:search;{0}#", searchKeyword);
        }

        /// <summary>
        /// Search the database for <string>. If ‘J’ or ‘search’ is used, it will search the whole database
        /// .If ‘K’ or ‘fastsearch’ is used, it will search only in the first column.
        /// </summary>
        /// <param name="searchKeyword"></param>
        /// <returns></returns>
        public string CommandDatabaseFastSearch(string searchKeyword)
        {
            return string.Format("COMMAND:fastsearch;{0}#", searchKeyword);
        }

        /// <summary>
        /// The command loads the record numbers used for the direct access feature.
        /// if many record request : record1[;record2;record3....]
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>
        public string CommandDirectAccessOfDatabase(string record)
        {
            return string.Format("COMMAND:A;{0}#", record);
        }

        /// <summary>
        /// Disconnects the client program from Obj INKDraw.
        /// </summary>
        /// <returns></returns>
        public string CommandDisconnnect()
        {
            return "COMMAND:disconnect#";
        }

        /// <summary>
        /// The command points the database to the specified record.
        /// </summary>
        /// <param name="recordNumber"></param>
        /// <returns></returns>
        public string CommandGotoRecord(int recordNumber)
        {
            return string.Format("COMMAND:goto;{0}#", recordNumber.ToString());
        }

        /// <summary>
        /// If connected to a layout, opened in same window. Otherwise, tries to open a new window.
        /// Loads the file specified by<file name>.If no path is given Inkdraw will load the file from the folders defined by the paths in preferences.The.ink extension is not necesary.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public string CommandLoadFile(string fileName)
        {
            return string.Format("COMMAND:load file;{0}#", fileName);
        }

        /// <summary>
        /// The print go command loads one print to the printhead.
        /// </summary>
        /// <returns></returns>
        public string CommandPrintGo()
        {
            return "COMMAND:printgo#";
        }

        /// <summary>
        /// Shuts down Obj INKDraw AND the PC. There is NO warning, shutdown is immediate.
        /// </summary>
        /// <returns></returns>
        public string CommandShutdown()
        {
            return "COMMAND:shut down#";
        }

        /// <summary>
        /// The command starts the printer
        /// </summary>
        /// <returns></returns>
        public string CommandStartPrint()
        {
            return "COMMAND:start#";
        }

        /// <summary>
        /// The command readies the printer for printing (R-), but the printer is not activated before an R+ command is send.Use this set of commands when using 
        /// more than one controller board to synchronize the printers. 
        /// If the commands are send when not connected to any message, they will be send to all open messages (print all).
        /// </summary>
        /// <returns></returns>
        public string CommandStartPrintOnHold()
        {
            return "COMMAND:start+/-#";
        }

        /// <summary>
        /// The stop print command stops the printer. If a layout is currently printing, the current print will finish.
        /// </summary>
        /// <returns></returns>
        public string CommandStopPrint()
        {
            return "COMMAND:stop#";
        }

        /// <summary>
        /// Load and execute ODBC QuickConnect (qdb type). 
        /// The quick connect file MUST be located in "database" directory.Use filename + extension.
        /// </summary>
        /// <returns></returns>
        public string CommandODBC()
        {
            return "COMMAND:ODBC;quickconnect.odb#";
        }

        /// <summary>
        /// Load a text file database. MUST be located in "database" directory. 
        /// Use filename + extension.You must have "keep references" on.
        /// </summary>
        /// <returns></returns>
        public string CommandTextFileLoad()
        {
            return "COMMAND:TXT;textdb.txt#";
        }

        /// <summary>
        /// Load an SQL Quick Connect File. MUST be located in "database" directory. Use filename+extension.
        /// </summary>
        /// <returns></returns>
        public string CommandLoadSQLFile()
        {
            return "COMMAND:SQL;quickconnect.qdb#";
        }

        /// <summary>
        /// Reload a datefile using default datefile name.
        /// </summary>
        /// <returns></returns>
        public string CommandLoadDatefileDef()
        {
            return "COMMAND:RDF#";
        }

        /// <summary>
        /// Clear buffer. If working in user-managed buffer, remove any stored prints.
        /// </summary>
        /// <returns></returns>
        public string CommandClearBuffer()
        {
            return "COMMAND:clear#";
        }

        /// <summary>
        /// Reset ink level on all boards, heads and pens
        /// </summary>
        /// <returns></returns>
        public string CommandResetLnkLevel()
        {
            return "COMMAND:inkreset#";
        }
        #endregion

        #region Object
        /// <summary>
        /// field objects only Changes the alignment of the field object. 
        /// Allowed values are ”left”, ”center”, or ”right”.
        /// </summary>
        /// <param name="objectName"></param>
        /// <param name="alignment"></param>
        /// <returns></returns>
        public string ObjectAlignment(string objectName, string alignment)
        {
            return string.Format("OBJECT:{0};ALN;{1}#", objectName, alignment);
        }

        /// <summary>
        /// barcode only
        /// Changes the contents of a barcode.This will only work if no objects have been
        /// inserted into the barcode.
        /// </summary>
        /// <param name="objectName"></param>
        /// <param name="contents"></param>
        /// <returns></returns>
        public string ObjectBarcodeContents(string objectName, string contents)
        {
            return string.Format("OBJECT:{0};CON;{1}#", objectName, contents);
        }

        /// <summary>
        /// Sets the ink spacing to <value>.
        /// </summary>
        /// <param name="objectName"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public string ObjectBarcodeInkSpacing(string objectName, string value)
        {
            return string.Format("OBJECT:{0};SPC;{1}#", objectName, value);
        }

        /// <summary>
        /// barcodes only
        /// Selects between the original Obj INKDraw barcodes and the expanded(Tec-It)
        /// barcodes.Allowed values for <module> are ”Tec-It”, ”expanded” or ”1” for the
        /// expanded module(everything else will set the original module). It is important to
        /// resend the barcode type after changing modules.
        /// </summary>
        /// <param name="objectName"></param>
        /// <param name="module"></param>
        /// <returns></returns>
        public string ObjectBarcodeModule(string objectName, string module)
        {
            return string.Format("OBJECT:{0};MOD;{1}#", objectName, module);
        }

        /// <summary>
        /// barcodes only
        /// Sets the type of the barcode(EAN13, Codabar, etc). The type must be equal to
        /// the type given in Obj INKDraw(EAN13 will work, EAN-13 will not).
        /// </summary>
        /// <param name="objectName"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public string ObjectBarcodeType(string objectName, string type)
        {
            return string.Format("OBJECT:{0};TYP;{1}#", objectName, type);
        }

        /// <summary>
        /// The object must be either a rectangle, line or ellipse
        /// Changes color on the specified object. If the object is a line there can be no
        /// <color 2>. Formats for colors are ”w”, ”W”, or ”-” for white and ”b”, ”B”, ”+” for black.
        /// original doc from format : OBJECT:<object name>;COL;<color 1>[<color 2>]#
        /// </summary>
        /// <param name="objectName"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        public string ObjectColor(string objectName, string color)
        {
            return string.Format("OBJECT:{0};COL;{1}#", objectName, color);
        }

        /// <summary>
        /// counters only
        /// Changes the minimum, maximum, or current(displayed) values of the counter.
        /// DIG sets the number of digits in the counter.
        /// DIR sets the direction of the counter, ”+” for counting up, ”-” for counting down.
        /// <lead in> is either space (” ”, ”space”), zero(”0”, ”zero”), or none(”none”).
        /// REP sets the repeat number of the counter.
        /// STP sets the value counter is increased each time
        /// </summary>
        /// <param name="objectName"></param>
        /// <param name="setValue"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public string ObjectCounterValues(string objectName, string setValue, string value)
        {
            return string.Format("OBJECT:{0};{1};{2}#", objectName, setValue, value);
        }

        /// <summary>
        /// The object name must not be equal to an existing object
        /// Creates a new object with the specified name and type.
        /// Valid object types are:
        /// OTText(text object)
        /// OTCounter(counter object)
        /// OTBarcode(barcode)
        /// OTDateTime(date/time object)
        /// OTLogo(logo)
        /// OTField(field)
        /// OTLine[or] OTLinje(line)
        /// OTRectangle(rectangle)
        /// OTEllipse(ellipse)
        /// OTPrintPos(Print Position) (??)
        /// </summary>
        /// <param name="objectName"></param>
        /// <param name="objectType"></param>
        /// <returns></returns>
        public string ObjectCreateObject(string objectName, string objectType)
        {
            return string.Format("OBJECT:{0};create;{1}#", objectName, objectType);
        }

        /// <summary>
        /// datamatrix barcodes only
        /// Sets the dot resolution.Valid sizes are: default, 10x10, 12x12, 14x14, 16x16,
        /// 18x18, 20x20, 22x22, 24x24, 26x26, 32x32, 36x36, 40x40, 44x44, 48x48,
        /// 52x52, 64x64, 72x72, 80x80, 88x88, 96x96, 104x104, 120x120, 132x132,
        /// 144x144, 8x18, 8x32, 12x26, 12x36, 16x36, and 16x48.If a non-valid size is
        /// given, default is used.Refer to datamatrix specifications for content size.
        /// </summary>
        /// <param name="objectName"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public string ObjectDatamatrixSize(string objectName, string size)
        {
            return string.Format("OBJECT:{0};DMS;{1}#", objectName, size);
        }

        /// <summary>
        /// Sets the format for the date objects. Available formats are all Windows formats
        /// as well as all special Inkdraw date format features.
        /// </summary>
        /// <param name="objectName"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public string ObjectDateFormat(string objectName, string format)
        {
            return string.Format("OBJECT:{0};FOR;{1}#", objectName, format);
        }

        /// <summary>
        /// Deletes the specified object and all sub-objects it might contain.
        /// </summary>
        /// <param name="objectName"></param>
        /// <returns></returns>
        public string ObjectDeleteObject(string objectName)
        {
            return string.Format("OBJECT:{0};delete#", objectName);
        }

        /// <summary>
        /// date/time objects only
        /// Sets the date of a date/time object. If sending a date it has to be of the format
        /// year/month/day(2003/3/19). Note that the DAT command is different from the DAT command used with fields.
        /// </summary>
        /// <param name="objectName"></param>
        /// <param name="orderType">EXP / DAT</param>
        /// <param name="format"></param>
        /// <returns></returns>
        public string ObjectExpiryDateSetDate(string objectName, string orderType, string format)
        {
            return string.Format("OBJECT:{0};{1};{2}#", objectName);
        }

        /// <summary>
        /// Field objects only. The command enters data to multiple (text only) lines in a field object. 
        /// Note that the DAT command is different from the DAT command used with date/times.
        /// OBJECT:<object name>;DAT;<line 1>;[<line 2>;<line 3>;…;]#
        /// </summary>
        /// <param name="objectName"></param>
        /// <param name="line"></param>
        /// <returns></returns>
        public string ObjectFieldData(string objectName, string line)
        {
            return string.Format("OBJECT:{0};DAT;{1}#", objectName);
        }

        /// <summary>
        /// All objects containing a font (fields, schedules, barcodes, texts, counters, and dates)
        /// Changes the font for the specified object. Font size and font style does not need
        /// to be present.Font style values are: 1=bold, 2=italic, 4=underline, 8=strikeout(cummulative).
        /// </summary>
        /// <param name="objectName"></param>
        /// <param name="fontName"></param>
        /// <param name="fontSize"></param>
        /// <param name="fontStyle"></param>
        /// <returns></returns>
        public string ObjectFont(string objectName, string fontName, string fontSize, string fontStyle)
        {
            return string.Format("OBJECT:<{0};FON;{1}[;{2};{3}]#", objectName, fontName, fontSize, fontStyle);
        }

        /// <summary>
        /// Turns on (“+”) or off (“-“) human readable text in the barcode.
        /// </summary>
        /// <param name="objectName"></param>
        /// <returns></returns>
        public string ObjectHumanReadable(string objectName)
        {
            return string.Format("OBJECT:{0};HUM;+/-#", objectName);
        }

        /// <summary>
        /// Inverts the object (”+”) or returns the object to normal (”-”).
        /// </summary>
        /// <param name="objectName"></param>
        /// <returns></returns>
        public string ObjectInvert(string objectName)
        {
            return string.Format("OBJECT:{0};invert;<+/->#", objectName);
        }

        /// <summary>
        /// only line objects
        /// Changes the position/size of the line.The start point of the line is 
        /// (<start x>,<start y>) and the end point is (<end x>, <end y>).
        /// OBJECT:<object name>;X-1;<start x>#
        /// OBJECT:<object name>; X-2;<end x>#
        /// OBJECT:<object name>; Y-1;<start y>#
        /// OBJECT:<object name>; Y-2;<end y>#
        /// </summary>
        /// <param name="objectName"></param>
        /// <param name="objectPostion"></param>
        /// <param name="objectPostionValue"></param>
        /// <returns></returns>
        public string ObjectLinePosition(string objectName, string objectPostion, string objectPostionValue)
        {
            return string.Format("OBJECT:{0};{1};{2}#", objectName, objectPostion, objectPostionValue);
        }

        /// <summary>
        /// only graphic objects (lines, rectangles and ellipses)
        /// Changes the line width.
        /// </summary>
        /// <param name="objectName"></param>
        /// <param name="objectWidth"></param>
        /// <returns></returns>
        public string ObjectLineWidth(string objectName, string objectWidth)
        {
            return string.Format("OBJECT:{0};WID;{1}#", objectName, objectWidth);
        }

        /// <summary>
        /// logos only
        /// Loads a new logo into the logo object, as specified by the name and path given.
        /// Uses LOGO search path.
        /// </summary>
        /// <param name="objectName"></param>
        /// <param name="objectNewPath"></param>
        /// <returns></returns>
        public string ObjectLoadLogo(string objectName, string objectNewPath)
        {
            return string.Format("OBJECT:{0};PAT;{1}#", objectName, objectNewPath);
        }

        /// <summary>
        /// Adds (”+”) or removes (”-”) an object from the monitor list.
        /// </summary>
        /// <param name="objectName"></param>
        /// <returns></returns>
        public string ObjectMonitoring(string objectName)
        {
            return string.Format("OBJECT:{0};monitor;<+/->#", objectName);
        }

        /// <summary>
        /// empty fields only
        /// Sets the number of lines in the field object. The command will not work unless the field is empty.
        /// </summary>
        /// <param name="objectName"></param>
        /// <param name="amountOfLine"></param>
        /// <returns></returns>
        public string ObjectNumberOfFieldLines(string objectName, string amountOfLine)
        {
            return string.Format("OBJECT:{0};LIN;{1}#", objectName, amountOfLine);
        }

        /// <summary>
        /// All objects except lines
        /// Changes the position of the object. Positions are measured as the upper left corner.
        /// </summary>
        /// <param name="objectName"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public string ObjectPosition(string objectName, string x, string y)
        {
            return string.Format("OBJECT:{0};POS;{1};{2}#", objectName, x,y);
        }

        /// <summary>
        /// Renames the object.
        /// </summary>
        /// <param name="objectName"></param>
        /// <param name="newObjectName"></param>
        /// <returns></returns>
        public string ObjectRenameObject(string objectName, string newObjectName)
        {
            return string.Format("OBJECT:{0};rename;{1}#", objectName, newObjectName);
        }

        /// <summary>
        /// All objects except lines
        /// Rotates the object. Valid values for <rotation> are 0, 90, 180, or 270 (degrees).
        /// </summary>
        /// <param name="objectName"></param>
        /// <param name="rotation"></param>
        /// <returns></returns>
        public string ObjectRotation(string objectName, string rotation)
        {
            return string.Format("OBJECT:{0};ROT;{1}#", objectName, rotation);
        }

        /// <summary>
        /// All objects except lines
        /// Changes the size of the object. Any font will be automatically resized to fit in the new size.
        /// </summary>
        /// <param name="objectName"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public string ObjectSize(string objectName, string width, string height)
        {
            return string.Format("OBJECT:{0};SIZ;{1};{2}#", objectName, width, height);
        }

        /// <summary>
        /// Sets the object snap point. 1=up/left, 2=up, 3=up/right, 4=left, 5=center, 6=right,
        /// 7=down/left, 8=down, 9=down/right.
        /// </summary>
        /// <param name="objectName"></param>
        /// <param name="snap"></param>
        /// <returns></returns>
        public string ObjectSnapPoint(string objectName, string snap)
        {
            return string.Format("OBJECT:{0};snap;{1}#", objectName, snap);
        }

        /// <summary>
        /// text objects only
        /// Writes a new text in the object. The object will be automatically resized to 
        /// fit the size of the new text.
        /// </summary>
        /// <param name="objectName"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public string ObjectText(string objectName, string text)
        {
            return string.Format("OBJECT:{0};TEX;{1}#", objectName, text);
        }

        /// <summary>
        /// Turns object transparency on (”+”) or off (”-”).
        /// </summary>
        /// <param name="objectName"></param>
        /// <returns></returns>
        public string ObjectTransperancy(string objectName)
        {
            return string.Format("OBJECT:{0};trans;<+/->#", objectName);
        }

        /// <summary>
        /// Verify the specified object (??)
        /// </summary>
        /// <param name="objectName"></param>
        /// <returns></returns>
        public string ObjectVerifyObject(string objectName)
        {
            return string.Format("OBJECT:{0};VER#", objectName);
        }
        #endregion

        #region PARAMETER
        /// <summary>
        /// The command will turn on/off endless mode. It will be accepted in print mode,
        /// but will not change before exiting printmode.
        /// </summary>
        /// <param name="plusMinus"></param>
        /// <returns></returns>
        public string ParameterEndless(string plusMinus)
        {
            return string.Format("PARAMETER:endless;{0}#", plusMinus);
        }

        /// <summary>
        /// Sets the global ink reduction. Valid values are 25, 50, 75. 25 can be replaced by
        /// 1, 50 by 2 and 75 by 3. Any other value will disable ink reduction.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public string ParameterGlobalInkReduction(string value)
        {
            return string.Format("PARAMETER:ink reduction;{0}#", value);
        }

        /// <summary>
        /// Makes adjustments to the print heads alignment.
        /// With offset you give an offset in PIXEL,
        /// engine1-4 is engine offset(also in PIXEL),
        /// Heads and engines are 1-based.
        /// upside, otherside, invert is activated with “+” or deactivated with anything else.
        /// PARAMETER:adjust;<head no>;offset;<value>#
        /// PARAMETER:adjust;<head no>; engine1;<value>#
        /// PARAMETER:adjust;<head no>; eng1;<value>#
        /// PARAMETER:adjust;<head no>;1;<value>#
        /// PARAMETER:adjust;<head no>; engine2;<value>#
        /// PARAMETER:adjust;<head no>; eng2;<value>#
        /// PARAMETER:adjust;<head no>;2;<value>#
        /// PARAMETER:adjust;<head no>; engine3;<value>#
        /// PARAMETER:adjust;<head no>; eng3;<value>#
        /// PARAMETER:adjust;<head no>;3;<value>#
        /// PARAMETER:adjust;<head no>; engine4;<value>#
        /// PARAMETER:adjust;<head no>; eng4;<value>#
        /// PARAMETER:adjust;<head no>;4;<value>#
        /// PARAMETER:adjust;<head no>; upside;+/-#
        /// PARAMETER:adjust;<head no>; upsidedown;+/-#
        /// PARAMETER:adjust;<head no>; other;+/-#
        /// PARAMETER:adjust;<head no>; otherside;+/-#
        /// PARAMETER:adjust;<head no>; invert;+/-#
        /// PARAMETER:adjust;<head no>; inverted;+/-#
        /// </summary>
        /// <param name="headNo"></param>
        /// <param name="location"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public string ParameterHeadAdjustments(string headNo, string location, string value)
        {
            return string.Format("PARAMETER:adjust;{0};{1};{2}#", headNo, location, value);
        }

        /// <summary>
        /// The command will set the HP printing resolution. Types are: 600x600 DPI (“1”),
        /// 300x300 DPI highspeed(“2”), 300x300 DPI with one row(“3”), 150x300 DPI
        /// (“4”), 600x300 DPI highspeed(“5”) and 300x600 DPI with one row(“6”). The
        /// optional parameter contains the relative nozzle offset, or, which row(“1” or “2”)
        /// to use with one row modes.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public string ParameterHPPrintMode(string type, string parameter)
        {
            return string.Format("PARAMETER:hp;{0}[;{1}]#", type, parameter);
        }

        /// <summary>
        /// Sets message length
        /// PARAMETER:size;<value>#
        /// PARAMETER:length;<value>#
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public string ParameterMessageLength(string type, string value)
        {
            return string.Format("PARAMETER:{0};{1}#", type, value);
        }

        /// <summary>
        /// Sets the modular encoder value.
        /// PARAMETER;modules;<value>#
        /// PARAMETER;modular;<value>#
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public string ParameterModules(string value)
        {
            return string.Format("PARAMETER:modules;{0}#", value);
        }

        /// <summary>
        /// The command will set the print buffer mode
        /// user-managed buffer(“user” / "usermanaged" / "user-managed" / "usermanaged"),
        /// specific: "1" , "10" print none: "0" print Any other values of<type> will set the buffer mode to default (unlimited).
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public string ParameterPrintBufferMode(string type)
        {
            return string.Format("PARAMETER:buffermode;{0}#", type);
        }

        /// <summary>
        /// Sets the print direction. + is left to right, - is right to left
        /// PARAMETER:direction;+/-#
        /// </summary>
        /// <param name="plusMinus"></param>
        /// <returns></returns>
        public string ParameterPrintDirection(string plusMinus)
        {
            return string.Format("PARAMETER:direction;{0}#", plusMinus);
        }

        /// <summary>
        /// Changes between position encoder (”pos”, ”position”, or ”P”), modular encoder
        /// (”mod”, ”modular”, or ”M”), and velocity(”vel”, ”velocity”, ”V”) modes.Changes
        /// will be accepted in print mode, but will not take effect before exiting print mode.
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public string ParameterPrintMode(string mode)
        {
            return string.Format("PARAMETER;mode;{0}#", mode);
        }

        /// <summary>
        /// The command will set the signal type to either print signal (”print”, or ”+”) or
        /// message signal(”message”, or ”-”).
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public string ParameterPrintSignal(string type)
        {
            return string.Format("PARAMETER:signal;{0}#", type);
        }

        /// <summary>
        /// Changes the encoder/velocity parameter. Exiting printmode is needed.
        /// PARAMETER:encoder;<value>#
        /// PARAMETER:velocity;<value>#
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public string ParameterPrintSpeed(string type, string value)
        {
            return string.Format("PARAMETER:{0};{1}#", type, value);
        }

        /// <summary>
        /// Starts a purge on the heads defined in head flags (1=head 1, 2=head 2, 4=head
        /// 3, 8=head 4, etc, multiple heads can be activated by adding their values). The
        /// purge will last the given time in msec.If you start purge by using the start
        /// command the heads will purge until you send the stop command.
        /// </summary>
        /// <param name="headFlags"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public string ParameterPurge(string headFlags, string time)
        {
            return string.Format("PARAMETER;purge;{0};{1}#", headFlags, time);
        }

        /// <summary>
        /// Starts a purge on the heads defined in head flags (1=head 1, 2=head 2, 4=head
        /// 3, 8=head 4, etc, multiple heads can be activated by adding their values). The
        /// purge will last the given time in msec.If you start purge by using the start
        /// command the heads will purge until you send the stop command.
        /// </summary>
        /// <param name="heads"></param>
        /// <returns></returns>
        public string ParameterPurgeStart(string heads)
        {
            return string.Format("PARAMETER:start purge;{0}#", heads);
        }

        /// <summary>
        /// Starts a purge on the heads defined in head flags (1=head 1, 2=head 2, 4=head
        /// 3, 8=head 4, etc, multiple heads can be activated by adding their values). The
        /// purge will last the given time in msec.If you start purge by using the start
        /// command the heads will purge until you send the stop command.
        /// </summary>
        /// <returns></returns>
        public string ParameterPurgeStop(string heads)
        {
            return "PARAMETER:stop purge#";
        }

        /// <summary>
        /// Turns quadrature on or off
        /// </summary>
        /// <param name="plusMinus"></param>
        /// <returns></returns>
        public string ParameterQuadrature(string plusMinus)
        {
            return string.Format("PARAMETER:quadrature;{0}#", plusMinus);
        }

        /// <summary>
        /// Sets repeat number and distance.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="distance"></param>
        /// <returns></returns>
        public string ParameterRepeat(string count, string distance)
        {
            return string.Format("PARAMETER;repeat;{0};{1}#", count, distance);
        }

        /// <summary>
        /// The command will change the sensor trigger to either positive (”pos”, ”positive”,
        /// or ”+”) edge, or negative(”neg”, ”negative”, ”-”) edge.The command will be
        /// accepted in print mode, but the change will not work before exiting and reentering
        /// print mode.
        /// </summary>
        /// <param name="edge"></param>
        /// <returns></returns>
        public string ParameterSetEdge(string edge)
        {
            return string.Format("PARAMETER:edge;{0}#", edge);
        }

        /// <summary>
        /// Sets the spit rate and burst size, and turns tickle on (“+”) or off (anything else).
        /// </summary>
        /// <param name="rate"></param>
        /// <param name="size"></param>
        /// <param name="plusMinus"></param>
        /// <returns></returns>
        public string ParameterSpit(string rate, string size, string plusMinus)
        {
            return string.Format("PARAMETER;spit;{0};{1};{2}#", rate, size, plusMinus);
        }

        /// <summary>
        /// The command changes the ”start mm” parameter. The given value must be in mms.
        /// </summary>
        /// <param name="startDistance"></param>
        /// <returns></returns>
        public string ParameterStartDistance(string startDistance)
        {
            return string.Format("PARAMETER:start;{0}#", startDistance);
        }

        /// <summary>
        /// Adjusts vertical stitching of the printheads
        /// </summary>
        /// <param name="headNo"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public string ParameterStictching(string headNo, string value)
        {
            return string.Format("PARAMETER:stitch;{0};{1}#", headNo, value);
        }
        #endregion

        #region REQUEST
        /// <summary>
        /// Connects to the specified message. File type (.ink) is mandatory. If just file name
        /// is given, file is loaded from ”files directory”.
        /// Specify "MAIN" to disconnect from a window and connect to "main window".
        /// Caution: only do this if needed.
        /// </summary>
        /// <param name="msgName"></param>
        /// <returns></returns>
        public string ReqeustConnectToMessage(string msgName)
        {
            return string.Format("REQUEST:connect;{0}#", msgName);
        }

        /// <summary>
        /// Returns the current conveyor velocity
        /// </summary>
        /// <returns></returns>
        public string ReqeustConveyorVelocity()
        {
            return "REQUEST:velocity#";
        }

        /// <summary>
        /// A list of the files available in {install}\files directory.
        /// </summary>
        /// <returns></returns>
        public string ReqeustFileDirectory()
        {
            return "REQUEST:directory#";
        }

        /// <summary>
        /// Returns the ink used per head since last request. Use this to build your own ink counter.
        /// </summary>
        /// <returns></returns>
        public string RequestInkUsage()
        {
            return "REQUEST:ink use#";
        }

        /// <summary>
        /// Returns the ink used per head, in absolute value since reset.
        /// Values are in ml.
        /// </summary>
        /// <returns></returns>
        public string RequestInkUsageAbsoluteValue()
        {
            return "REQUEST:ink abs#";
        }

        /// <summary>
        /// Returns a list of open layouts.
        /// </summary>
        /// <returns></returns>
        public string RequestListOfOpenLayouts()
        {
            return "REQUEST:messages#";
        }

        /// <summary>
        /// Returns a list of open layouts.
        /// </summary>
        /// <returns></returns>
        public string RequestFiles()
        {
            return "REQUEST:file list#";
        }

        /// <summary>
        /// Use to check if the connection is alive and working
        /// </summary>
        /// <returns></returns>
        public string ReqeustPing()
        {
            return "REQUEST:ECHO#";
        }

        /// <summary>
        /// Checks if the CB got space for another print in the buffer. Used with usermanaged buffer.
        /// </summary>
        /// <returns></returns>
        public string RequestPrintReady()
        {
            return "REQUEST:print ready#";
        }

        /// <summary>
        /// Inkdraw returns status of the printer (online/offline/printing) as well as hardware
        /// status(fuses, inklow).
        /// </summary>
        /// <returns></returns>
        public string ReqeustPrinterStatus()
        {
            return "REQUEST:status#";
        }

        /// <summary>
        /// Inkdraw returns all data available for the object.
        /// </summary>
        /// <param name="objectName"></param>
        /// <returns></returns>
        public string ReqeustRequestDataOfAnObject(string objectName)
        {
            return string.Format("REQUEST:object data;{0}#", objectName);
        }

        /// <summary>
        /// Inkdraw returns a list of objects from the current layout
        /// Ethernet mode: must be connected to a layout
        /// </summary>
        /// <returns></returns>
        public string RequestRequestListOfObjects()
        {
            return "REQUEST:object list#";
        }

        /// <summary>
        /// Inkdraw returns all available parameters.
        /// </summary>
        /// <returns></returns>
        public string ReqeustRequestParameterData()
        {
            return "REQUEST:parameters#";
        }

        /// <summary>
        /// Synchronize boards
        /// </summary>
        /// <returns></returns>
        public string ReqeustSynchSignal()
        {
            return "REQUEST:synch signal#";
        }

        #endregion



    }
}
