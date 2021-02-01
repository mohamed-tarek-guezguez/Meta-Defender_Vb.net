Imports System.ComponentModel
Imports System.Web.Script.Serialization
Imports System.ComponentModel.DisplayNameAttribute

Public Class JScanInfo

    Public Class PrimaryInfo
        Public Property data_id As String
        Public Property status As String
        Public Property in_queue As Integer
        Public Property rest_ip As String
    End Class

    Public Class Rootobject
        Public Property file_id As String
        Public Property data_id As String
        Public Property process_info As Process_Info
        Public Property scan_results As Scan_Results
        Public Property file_info As File_Info
        Public Property top_threat As Integer
        Public Property share_file As Integer
        Public Property rest_version As String
        Public Property original_file As Original_File
    End Class

    Public Class Process_Info
        Public Property user_agent As String
        Public Property result As String
        Public Property progress_percentage As Integer
        Public Property profile As String
        Public Property file_type_skipped_scan As Boolean
        Public Property blocked_reason As String
    End Class

    Public Class Scan_Results
        Public Property scan_details As Scan_Details
        Public Property rescan_available As Boolean
        Public Property data_id As String
        Public Property scan_all_result_i As Integer
        Public Property start_time As Date
        Public Property total_time As Integer
        Public Property total_avs As Integer
        Public Property total_detected_avs As Integer
        Public Property progress_percentage As Integer
        Public Property in_queue As Integer
        Public Property scan_all_result_a As String
    End Class

    Public Class Scan_Details

        Public Property Zoner As Zoner
        Public Property Zillya As Zillya
        Public Property VirusBlokAda As Virusblokada
        Public Property TrendMicroHouseCall As TrendmicroHouseCall
        Public Property TrendMicro As Trendmicro
        Public Property TotalDefense As TotalDefense
        Public Property ThreatTrack As Threattrack
        Public Property SUPERAntiSpyware As Superantispyware
        Public Property Sophos As Sophos
        Public Property QuickHeal As QuickHeal
        Public Property Preventon As Preventon
        Public Property nProtect As Nprotect
        Public Property NANOAV As NANOAV
        Public Property McAfee As Mcafee
        Public Property K7 As K7
        Public Property Jiangmin As Jiangmin
        Public Property Ikarus As Ikarus
        Public Property Hauri As Hauri
        Public Property Fortinet As Fortinet
        Public Property Filseclab As Filseclab
        Public Property Fsecure As FSecure
        Public Property Fprot As FProt
        Public Property ESET As ESET
        Public Property Emsisoft As Emsisoft
        Public Property Cyren As Cyren
        Public Property ClamAV As Clamav
        Public Property ByteHero As Bytehero
        Public Property BitDefender As Bitdefender
        Public Property Avira As Avira
        Public Property AVG As AVG
        Public Property Antiy As Antiy
        Public Property Ahnlab As Ahnlab
        Public Property Agnitum As Agnitum
        Public Property AegisLab As Aegislab
        Public Property VirITeXplorer As VirITExplorer
        Public Property DrWebGateway As DrWebGateway
    End Class

    Public Class Zoner
        Public Property wait_time As Integer
        Public Property threat_found As String
        Public Property scan_time As Integer
        Public Property scan_result_i As Integer
        Public Property def_time As Date
    End Class

    Public Class Zillya
        Public Property wait_time As Integer
        Public Property threat_found As String
        Public Property scan_time As Integer
        Public Property scan_result_i As Integer
        Public Property def_time As Date
    End Class

    Public Class Virusblokada
        Public Property wait_time As Integer
        Public Property threat_found As String
        Public Property scan_time As Integer
        Public Property scan_result_i As Integer
        Public Property def_time As Date
    End Class

    Public Class TrendmicroHouseCall
        Public Property wait_time As Integer
        Public Property threat_found As String
        Public Property scan_time As Integer
        Public Property scan_result_i As Integer
        Public Property def_time As Date
    End Class

    Public Class Trendmicro
        Public Property wait_time As Integer
        Public Property threat_found As String
        Public Property scan_time As Integer
        Public Property scan_result_i As Integer
        Public Property def_time As Date
    End Class

    Public Class TotalDefense
        Public Property wait_time As Integer
        Public Property threat_found As String
        Public Property scan_time As Integer
        Public Property scan_result_i As Integer
        Public Property def_time As Date
    End Class

    Public Class Threattrack
        Public Property wait_time As Integer
        Public Property threat_found As String
        Public Property scan_time As Integer
        Public Property scan_result_i As Integer
        Public Property def_time As Date
    End Class

    Public Class Superantispyware
        Public Property wait_time As Integer
        Public Property threat_found As String
        Public Property scan_time As Integer
        Public Property scan_result_i As Integer
        Public Property def_time As Date
    End Class

    Public Class Sophos
        Public Property wait_time As Integer
        Public Property threat_found As String
        Public Property scan_time As Integer
        Public Property scan_result_i As Integer
        Public Property def_time As Date
    End Class

    Public Class QuickHeal
        Public Property wait_time As Integer
        Public Property threat_found As String
        Public Property scan_time As Integer
        Public Property scan_result_i As Integer
        Public Property def_time As Date
    End Class

    Public Class Preventon
        Public Property wait_time As Integer
        Public Property threat_found As String
        Public Property scan_time As Integer
        Public Property scan_result_i As Integer
        Public Property def_time As Date
    End Class

    Public Class Nprotect
        Public Property wait_time As Integer
        Public Property threat_found As String
        Public Property scan_time As Integer
        Public Property scan_result_i As Integer
        Public Property def_time As Date
    End Class

    Public Class NANOAV
        Public Property wait_time As Integer
        Public Property threat_found As String
        Public Property scan_time As Integer
        Public Property scan_result_i As Integer
        Public Property def_time As Date
    End Class

    Public Class Mcafee
        Public Property wait_time As Integer
        Public Property threat_found As String
        Public Property scan_time As Integer
        Public Property scan_result_i As Integer
        Public Property def_time As Date
    End Class

    Public Class K7
        Public Property wait_time As Integer
        Public Property threat_found As String
        Public Property scan_time As Integer
        Public Property scan_result_i As Integer
        Public Property def_time As Date
    End Class

    Public Class Jiangmin
        Public Property wait_time As Integer
        Public Property threat_found As String
        Public Property scan_time As Integer
        Public Property scan_result_i As Integer
        Public Property def_time As Date
    End Class

    Public Class Ikarus
        Public Property wait_time As Integer
        Public Property threat_found As String
        Public Property scan_time As Integer
        Public Property scan_result_i As Integer
        Public Property def_time As Date
    End Class

    Public Class Hauri
        Public Property wait_time As Integer
        Public Property threat_found As String
        Public Property scan_time As Integer
        Public Property scan_result_i As Integer
        Public Property def_time As Date
    End Class

    Public Class Fortinet
        Public Property wait_time As Integer
        Public Property threat_found As String
        Public Property scan_time As Integer
        Public Property scan_result_i As Integer
        Public Property def_time As Date
    End Class

    Public Class Filseclab
        Public Property wait_time As Integer
        Public Property threat_found As String
        Public Property scan_time As Integer
        Public Property scan_result_i As Integer
        Public Property def_time As Date
    End Class

    Public Class FSecure
        Public Property wait_time As Integer
        Public Property threat_found As String
        Public Property scan_time As Integer
        Public Property scan_result_i As Integer
        Public Property def_time As Date
    End Class

    Public Class FProt
        Public Property wait_time As Integer
        Public Property threat_found As String
        Public Property scan_time As Integer
        Public Property scan_result_i As Integer
        Public Property def_time As Date
    End Class

    Public Class ESET
        Public Property wait_time As Integer
        Public Property threat_found As String
        Public Property scan_time As Integer
        Public Property scan_result_i As Integer
        Public Property def_time As Date
    End Class

    Public Class Emsisoft
        Public Property wait_time As Integer
        Public Property threat_found As String
        Public Property scan_time As Integer
        Public Property scan_result_i As Integer
        Public Property def_time As Date
    End Class

    Public Class Cyren
        Public Property wait_time As Integer
        Public Property threat_found As String
        Public Property scan_time As Integer
        Public Property scan_result_i As Integer
        Public Property def_time As Date
    End Class

    Public Class Clamav
        Public Property wait_time As Integer
        Public Property threat_found As String
        Public Property scan_time As Integer
        Public Property scan_result_i As Integer
        Public Property def_time As Date
    End Class

    Public Class Bytehero
        Public Property wait_time As Integer
        Public Property threat_found As String
        Public Property scan_time As Integer
        Public Property scan_result_i As Integer
        Public Property def_time As Date
    End Class

    Public Class Bitdefender
        Public Property wait_time As Integer
        Public Property threat_found As String
        Public Property scan_time As Integer
        Public Property scan_result_i As Integer
        Public Property def_time As Date
    End Class

    Public Class Avira
        Public Property wait_time As Integer
        Public Property threat_found As String
        Public Property scan_time As Integer
        Public Property scan_result_i As Integer
        Public Property def_time As Date
    End Class

    Public Class AVG
        Public Property wait_time As Integer
        Public Property threat_found As String
        Public Property scan_time As Integer
        Public Property scan_result_i As Integer
        Public Property def_time As Date
    End Class

    Public Class Antiy
        Public Property wait_time As Integer
        Public Property threat_found As String
        Public Property scan_time As Integer
        Public Property scan_result_i As Integer
        Public Property def_time As Date
    End Class

    Public Class Ahnlab
        Public Property wait_time As Integer
        Public Property threat_found As String
        Public Property scan_time As Integer
        Public Property scan_result_i As Integer
        Public Property def_time As Date
    End Class

    Public Class Agnitum
        Public Property wait_time As Integer
        Public Property threat_found As String
        Public Property scan_time As Integer
        Public Property scan_result_i As Integer
        Public Property def_time As Date
    End Class

    Public Class Aegislab
        Public Property wait_time As Integer
        Public Property threat_found As String
        Public Property scan_time As Integer
        Public Property scan_result_i As Integer
        Public Property def_time As Date
    End Class

    Public Class VirITExplorer
        Public Property wait_time As Integer
        Public Property threat_found As String
        Public Property scan_time As Integer
        Public Property scan_result_i As Integer
        Public Property def_time As Date
    End Class

    Public Class DrWebGateway
        Public Property wait_time As Integer
        Public Property threat_found As String
        Public Property scan_time As Integer
        Public Property scan_result_i As Integer
        Public Property def_time As Date
    End Class

    Public Class File_Info
        Public Property file_size As Integer
        Public Property upload_timestamp As Date
        Public Property md5 As String
        Public Property sha1 As String
        Public Property sha256 As String
        Public Property file_type_category As String
        Public Property file_type_description As String
        Public Property file_type_extension As String
        Public Property display_name As String
    End Class

    Public Class Original_File
        Public Property detected_by As Integer
        Public Property progress_percentage As Integer
        Public Property scan_result_i As Integer
        Public Property data_id As String
    End Class

End Class
