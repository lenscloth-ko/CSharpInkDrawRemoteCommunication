using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkDrawRemoteCommunicationLibrary
{
    public class InkDrawErrorCodes
    {
        /// <summary>
        /// 에러코드 정의 테이블
        /// </summary>
        private DataTable inkDrawErrorCodesTable = new DataTable("inkDrawErrorCodesTable");

        public InkDrawErrorCodes()
        {
            init_inkDrawErrorCodesTable();
        }

        public string ErrorMessage(string inputErrorCode)
        {
            DataRow[] rows;
            rows = this.inkDrawErrorCodesTable.Select(
                string.Format("ErrorNum = '{0}'", inputErrorCode)
                );

            try
            {
                return rows[0]["ErrorMessage"].ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        #region inkDrawErrorCodesTable 테이블정보
        /// <summary>
        /// inkDrawErrorCodesTable
        /// </summary>
        private void init_inkDrawErrorCodesTable()
        {
            //CodeSet 비교할때(A와 B) datatable에서 대소문자를 구분해야함!!
            this.inkDrawErrorCodesTable.CaseSensitive = true;

            //항목
            //Value	128A 128B 128C 	(x)Code(ASCII) Pattern Widths
            this.inkDrawErrorCodesTable.Columns.Add("ErrorNum", typeof(string));
            this.inkDrawErrorCodesTable.Columns.Add("ErrorMessage", typeof(string));

            //하..노가다...data
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "000", "OK" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "001", "Forkert password" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "002", "Ukendt kommando" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "010", "Password OK" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "020", "Purge udført" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "021", "Purge startet" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "030", "Kalibrering udført" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "100", "COMMAND: Ukendt kommando" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "101", "COMMAND: S: Printer kører ikke" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "102", "COMMAND: R: Printer kører allerede" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "103", "COMMAND: F: Fil ikke fundet" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "104", "COMMAND: G/A: Database ikke aktiv" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "105", "COMMAND: Ulovlige data, et tal var ventet" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "106", "COMMAND: S: Kan ikke stoppe printer" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "107", "COMMAND: R: Printer kører ikke" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "108", "COMMAND: F: For mange åbne vinduer" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "109", "COMMAND: P: Ikke i user-managed buffer" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "110", "COMMAND: DATABASE: Record ikke fundet" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "120", "COMMAND: kalibrering virker kun på HP hoveder" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "121", "COMMAND: kalibrering fejlet" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "130", "COMMAND: C: Kan ikke lukke hovedvinduet" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "131", "COMMAND: C: Kan ikke et printende vindue" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "200", "REQUEST: Ukendt kommando" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "210", "REQUEST: CONNECT: Besked ikke fundet" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "211", "REQUEST: CONNECT: Besked i brug" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "220", "REQUEST: OBJECT DATA: Object ikke fundet" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "230", "REQUEST: VELOCITY: Ikke i print mode" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "300", "OBJECT: Object ikke fundet" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "301", "OBJECT: Ukendt kommando" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "302", "OBJECT: Ugyldig object type (server fejl!)" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "310", "OBJECT: POSITION: Ugyldig X værdi" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "311", "OBJECT: POSITION: Ugyldig Y værdi" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "312", "OBJECT: POSITION: X værdi mangler" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "313", "OBJECT: POSITION: Y værdi mangler" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "314", "OBJECT: SIZE: Ugyldig X værdi" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "315", "OBJECT: SIZE: Ugyldig Y værdi" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "316", "OBJECT: SIZE: X værdi mangler" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "317", "OBJECT: SIZE: Y værdi mangler" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "318", "OBJECT: FONT: Ulovlige data, et tal var ventet" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "319", "OBJECT: COLOR: Ulovlige data" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "320", "OBJECT: COUNTER: Ulovlige data, et tal var ventet" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "321", "OBJECT: FONT: Ugyldig font type" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "330", "OBJECT: DATO: Ulovlige data, et tal var ventet" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "331", "OBJECT: DATO: Ulovlige data, formatet dd/mm/åå var ventet" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "332", "OBJECT: DATO: Funktion fejlet" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "335", "OBJECT: TEXT: ugyldigt mellerum, et tal var ventet" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "340", "OBJECT: LOGO: Fil ikke fundet" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "341", "OBJECT: LOGO: Kan ikke ændre logo" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "342", "OBJECT: LOGO: Ulovlige data, et tal var ventet" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "352", "OBJECT: BARCODE: Funktion fejlet" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "353", "OBJECT: BARCODE: Ugyldig barkode type" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "354", "OBJECT: BARCODE: Ugyldig checksum værdi, 0-2 er tilladt" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "355", "OBJECT: BARCODE: Ugyldig ink spacing, et tal var ventet" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "356", "OBJECT: BARCODE: Kun anvendelig på datamatrix" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "357", "OBJECT: BARCODE: Ugyldigt format, se dokumentation" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "360", "OBJECT: LINE: Ulovlige data, et tal var ventet" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "370", "OBJECT: RECTANGLE: Ulovlige data, et tal var ventet" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "380", "OBJECT: ELLIPSE: Ulovlige data, et tal var ventet" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "390", "OBJECT: FIELD: Ulovlige data, et tal var ventet" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "391", "OBJECT: FIELD: Ugyldig kommando" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "392", "OBJECT: FIELD: For mange linier" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "393", "OBJECT: FIELD: Ukendt alignment" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "400", "OBJECT: ROTATION: Kun rotationer på 0, 90, 180, and 270 grader tilladt" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "500", "OBJECT: SNAP: Valid values are 1-9" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "600", "OBJECT: SCHEDULE: Ulovlige data, tal;dag;tid;tekst var ventet" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "1000", "PARAMETER: Ukendt kommando" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "1010", "PARAMETER: START: Ulovlige data, et tal var ventet" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "1020", "PARAMETER: SIDE: Ukendt side" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "1030", "PARAMETER: SIGNAL: Ukendt signal" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "1040", "PARAMETER: ENDLESS: Ulovlige data, + eller - var ventet" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "1050", "PARAMETER: MODE: Ulovlige data, P, M eller V var ventet" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "1060", "PARAMETER: VELOCITY/ENCODER: Ulovlige data, et tal var ventet" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "1070", "PARAMETER: MODULES: Ulovlige data, et tal var ventet" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "1080", "PARAMETER: REPEAT: forventet format er antal;afstand" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "1090", "PARAMETER: SPIT: forventet format er frekvens;størrelse;+/- (tickle)" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "1100", "PARAMETER: PURGE: forventet format er hoved_bits;længde" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "1101", "PARAMETER: START PURGE: forventet format er hoved_bits" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "1110", "PARAMETER: HP: forventet format er type[;værdi]" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "1120", "PARAMETER: SIZE: ulovlige data, et tal var ventet" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "1130", "PARAMETER: STITCH: forventet format er hovede;værdi" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "1140", "PARAMETER: STITCH: ugyldigt hovede, 1-15 tilladt" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "1200", "ADJUST: Ugyldigt print hovede" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "1201", "ADJUST: Ukendt kommando" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "1202", "ADJUST: Ugyldigt hoved offset, et tal var ventet" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "1203", "ADJUST: Ugyldigt engine offset, et tal var ventet" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "1300", "DATABASE: Requires an assigned database" });
            this.inkDrawErrorCodesTable.Rows.Add(new object[] { "1301", "DATABASE: File not found" });
        } // end init_inkDrawErrorCodesTable
        #endregion

    } // end class InkDrawErrorCodes
}// end namespace
