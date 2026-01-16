\
\ @file aximc.fs
\ @brief AXIMC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief AXIMC peripheral ID4 register
\ Address offset: 0x1FD0
\ Reset value: 0x00000004
\

$0000000f constant AXIMC_AXIMC_PERIPH_ID_4_JEP106CON                \ JEP106 continuation code
$000000f0 constant AXIMC_AXIMC_PERIPH_ID_4_K4COUNT                  \ register file size


\
\ @brief AXIMC peripheral ID5 register
\ Address offset: 0x1FD4
\ Reset value: 0x00000000
\

$000000ff constant AXIMC_AXIMC_PERIPH_ID_5_PERIPH_ID_5              \ reserved, not used.


\
\ @brief AXIMC peripheral ID6 register
\ Address offset: 0x1FD8
\ Reset value: 0x00000000
\

$000000ff constant AXIMC_AXIMC_PERIPH_ID_6_PERIPH_ID_6              \ reserved, not used.


\
\ @brief AXIMC peripheral ID7 register
\ Address offset: 0x1FDC
\ Reset value: 0x00000000
\

$000000ff constant AXIMC_AXIMC_PERIPH_ID_7_PERIPH_ID_7              \ reserved, not used.


\
\ @brief AXIMC peripheral ID0 register
\ Address offset: 0x1FE0
\ Reset value: 0x00000000
\

$000000ff constant AXIMC_AXIMC_PERIPH_ID_0_PERIPH_ID_0              \ part number [7:0]


\
\ @brief AXIMC peripheral ID1 register
\ Address offset: 0x1FE4
\ Reset value: 0x000000B4
\

$000000ff constant AXIMC_AXIMC_PERIPH_ID_1_PERIPH_ID_1              \ JEP106 identity [3:0], part number [11:8]


\
\ @brief AXIMC peripheral ID2 register
\ Address offset: 0x1FE8
\ Reset value: 0x0000003B
\

$000000ff constant AXIMC_AXIMC_PERIPH_ID_2_PERIPH_ID_2              \ part revision, JEP106 code flag, JEP106 identity [6:4]


\
\ @brief AXIMC peripheral ID3 register
\ Address offset: 0x1FEC
\ Reset value: 0x00000000
\

$0000000f constant AXIMC_AXIMC_PERIPH_ID_3_CUST_MOD_NUM             \ customer modification
$000000f0 constant AXIMC_AXIMC_PERIPH_ID_3_REV_AND                  \ customer version


\
\ @brief AXIMC component ID0 register
\ Address offset: 0x1FF0
\ Reset value: 0x0000000D
\

$000000ff constant AXIMC_AXIMC_COMP_ID_0_PREAMBLE                   \ preamble bits [7:0]


\
\ @brief AXIMC component ID1 register
\ Address offset: 0x1FF4
\ Reset value: 0x000000F0
\

$0000000f constant AXIMC_AXIMC_COMP_ID_1_PREAMBLE                   \ preamble bits [11:8]
$000000f0 constant AXIMC_AXIMC_COMP_ID_1_CLASS                      \ Component class


\
\ @brief AXIMC component ID2 register
\ Address offset: 0x1FF8
\ Reset value: 0x00000005
\

$000000ff constant AXIMC_AXIMC_COMP_ID_2_PREAMBLE                   \ preamble bits [19:12]


\
\ @brief AXIMC component ID3 register
\ Address offset: 0x1FFC
\ Reset value: 0x000000B1
\

$000000ff constant AXIMC_AXIMC_COMP_ID_3_PREAMBLE                   \ preamble bits [27:20]


\
\ @brief AXIMC master 0 packing functionality register
\ Address offset: 0x42024
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_AXIMC_M0_FN_MOD2_BYPASS_MERGE              \ Disable packing of beats to match the output data width Unaligned transactions are not realigned to the input data word boundary.


\
\ @brief AXIMC master 0 AHB conversion override functionality register
\ Address offset: 0x42028
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_AXIMC_M0_FN_MOD_AHB_RD_INC_OVERRIDE        \ Converts all AHB-Lite write transactions to a series of single beat AXI transactions, and each AHB-Lite write beat is acknowledged with the AXI buffered write response.
$00000002 constant AXIMC_AXIMC_M0_FN_MOD_AHB_WR_INC_OVERRIDE        \ Converts all AHB-Lite read transactions to a series of single beat AXI transactions


\
\ @brief AXIMC master 0 read priority register
\ Address offset: 0x42100
\ Reset value: 0x00000006
\

$0000000f constant AXIMC_AXIMC_M0_READ_QOS_AR_QOS                   \ read channel QoS setting


\
\ @brief AXIMC master 0 write priority register
\ Address offset: 0x42104
\ Reset value: 0x00000006
\

$0000000f constant AXIMC_AXIMC_M0_WRITE_QOS_AW_QOS                  \ write channel QoS setting


\
\ @brief AXIMC master 0 issuing capability override functionality register
\ Address offset: 0x42108
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_AXIMC_M0_FN_MOD_READ_ISS_OVERRIDE          \ override AMIB read issuing capability
$00000002 constant AXIMC_AXIMC_M0_FN_MOD_WRITE_ISS_OVERRIDE         \ override AMIB write issuing capability


\
\ @brief AXIMC master 1 packing functionality register
\ Address offset: 0x43024
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_AXIMC_M1_FN_MOD2_BYPASS_MERGE              \ Disable packing of beats to match the output data width Unaligned transactions are not realigned to the input data word boundary.


\
\ @brief AXIMC master 1 AHB conversion override functionality register
\ Address offset: 0x43028
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_AXIMC_M1_FN_MOD_AHB_RD_INC_OVERRIDE        \ Converts all AHB-Lite write transactions to a series of single beat AXI transactions, and each AHB-Lite write beat is acknowledged with the AXI buffered write response.
$00000002 constant AXIMC_AXIMC_M1_FN_MOD_AHB_WR_INC_OVERRIDE        \ Converts all AHB-Lite read transactions to a series of single beat AXI transactions


\
\ @brief AXIMC master 1 read priority register
\ Address offset: 0x43100
\ Reset value: 0x00000006
\

$0000000f constant AXIMC_AXIMC_M1_READ_QOS_AR_QOS                   \ read channel QoS setting


\
\ @brief AXIMC master 1 write priority register
\ Address offset: 0x43104
\ Reset value: 0x00000006
\

$0000000f constant AXIMC_AXIMC_M1_WRITE_QOS_AW_QOS                  \ write channel QoS setting


\
\ @brief AXIMC master 1 issuing capability override functionality register
\ Address offset: 0x43108
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_AXIMC_M1_FN_MOD_READ_ISS_OVERRIDE          \ override AMIB read issuing capability
$00000002 constant AXIMC_AXIMC_M1_FN_MOD_WRITE_ISS_OVERRIDE         \ override AMIB write issuing capability


\
\ @brief AXIMC master 2 packing functionality register
\ Address offset: 0x44024
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_AXIMC_M2_FN_MOD2_BYPASS_MERGE              \ Disable packing of beats to match the output data width Unaligned transactions are not realigned to the input data word boundary.


\
\ @brief AXIMC master 2 AHB conversion override functionality register
\ Address offset: 0x44028
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_AXIMC_M2_FN_MOD_AHB_RD_INC_OVERRIDE        \ Converts all AHB-Lite write transactions to a series of single beat AXI transactions, and each AHB-Lite write beat is acknowledged with the AXI buffered write response.
$00000002 constant AXIMC_AXIMC_M2_FN_MOD_AHB_WR_INC_OVERRIDE        \ Converts all AHB-Lite read transactions to a series of single beat AXI transactions


\
\ @brief AXIMC master 2 read priority register
\ Address offset: 0x44100
\ Reset value: 0x00000006
\

$0000000f constant AXIMC_AXIMC_M2_READ_QOS_AR_QOS                   \ read channel QoS setting


\
\ @brief AXIMC master 2 write priority register
\ Address offset: 0x44104
\ Reset value: 0x00000006
\

$0000000f constant AXIMC_AXIMC_M2_WRITE_QOS_AW_QOS                  \ write channel QoS setting


\
\ @brief AXIMC master 2 issuing capability override functionality register
\ Address offset: 0x44108
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_AXIMC_M2_FN_MOD_READ_ISS_OVERRIDE          \ override AMIB read issuing capability
$00000002 constant AXIMC_AXIMC_M2_FN_MOD_WRITE_ISS_OVERRIDE         \ override AMIB write issuing capability


\
\ @brief AXIMC master 3 read priority register
\ Address offset: 0x45100
\ Reset value: 0x00000007
\

$0000000f constant AXIMC_AXIMC_M3_READ_QOS_AR_QOS                   \ read channel QoS setting


\
\ @brief AXIMC master 3 write priority register
\ Address offset: 0x45104
\ Reset value: 0x00000007
\

$0000000f constant AXIMC_AXIMC_M3_WRITE_QOS_AW_QOS                  \ write channel QoS setting


\
\ @brief AXIMC master 3 packing functionality register
\ Address offset: 0x45108
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_AXIMC_M3_FN_MOD_READ_ISS_OVERRIDE          \ override AMIB read issuing capability
$00000002 constant AXIMC_AXIMC_M3_FN_MOD_WRITE_ISS_OVERRIDE         \ override AMIB write issuing capability


\
\ @brief AXIMC long burst capability inhibition register
\ Address offset: 0x4602C
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_AXIMC_M4_FN_MOD_LB_FN_MOD_LB               \ controls burst breaking of long bursts


\
\ @brief AXIMC master 4 read priority register
\ Address offset: 0x46100
\ Reset value: 0x00000007
\

$0000000f constant AXIMC_AXIMC_M4_READ_QOS_AR_QOS                   \ read channel QoS setting


\
\ @brief AXIMC master 4 write priority register
\ Address offset: 0x46104
\ Reset value: 0x00000007
\

$0000000f constant AXIMC_AXIMC_M4_WRITE_QOS_AW_QOS                  \ write channel QoS setting


\
\ @brief AXIMC master 4 packing functionality register
\ Address offset: 0x46108
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_AXIMC_M4_FN_MOD_READ_ISS_OVERRIDE          \ override AMIB read issuing capability
$00000002 constant AXIMC_AXIMC_M4_FN_MOD_WRITE_ISS_OVERRIDE         \ override AMIB write issuing capability


\
\ @brief AXIMC master 5 packing functionality register
\ Address offset: 0x47024
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_AXIMC_M5_FN_MOD2_BYPASS_MERGE              \ Disable packing of beats to match the output data width Unaligned transactions are not realigned to the input data word boundary.


\
\ @brief AXIMC master 5 AHB conversion override functionality register
\ Address offset: 0x47028
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_AXIMC_M5_FN_MOD_AHB_RD_INC_OVERRIDE        \ converts all AHB-Lite write transactions to a series of single beat AXI transactions, and each AHB-Lite write beat is acknowledged with the AXI buffered write response.
$00000002 constant AXIMC_AXIMC_M5_FN_MOD_AHB_WR_INC_OVERRIDE        \ converts all AHB-Lite read transactions to a series of single beat AXI transactions


\
\ @brief AXIMC master 5 read priority register
\ Address offset: 0x47100
\ Reset value: 0x00000004
\

$0000000f constant AXIMC_AXIMC_M5_READ_QOS_AR_QOS                   \ read channel QoS setting


\
\ @brief AXIMC master 5 write priority register
\ Address offset: 0x47104
\ Reset value: 0x00000004
\

$0000000f constant AXIMC_AXIMC_M5_WRITE_QOS_AW_QOS                  \ write channel QoS setting


\
\ @brief AXIMC master 5 issuing capability override functionality register
\ Address offset: 0x47108
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_AXIMC_M5_FN_MOD_READ_ISS_OVERRIDE          \ override AMIB read issuing capability
$00000002 constant AXIMC_AXIMC_M5_FN_MOD_WRITE_ISS_OVERRIDE         \ override AMIB write issuing capability


\
\ @brief AXIMC master 6 packing functionality register
\ Address offset: 0x48024
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_AXIMC_M6_FN_MOD2_BYPASS_MERGE              \ Disable packing of beats to match the output data width Unaligned transactions are not realigned to the input data word boundary.


\
\ @brief AXIMC master 6 AHB conversion override functionality register
\ Address offset: 0x48028
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_AXIMC_M6_FN_MOD_AHB_RD_INC_OVERRIDE        \ converts all AHB-Lite write transactions to a series of single beat AXI transactions, and each AHB-Lite write beat is acknowledged with the AXI buffered write response.
$00000002 constant AXIMC_AXIMC_M6_FN_MOD_AHB_WR_INC_OVERRIDE        \ converts all AHB-Lite read transactions to a series of single beat AXI transactions


\
\ @brief AXIMC master 6 read priority register
\ Address offset: 0x48100
\ Reset value: 0x00000004
\

$0000000f constant AXIMC_AXIMC_M6_READ_QOS_AR_QOS                   \ read channel QoS setting


\
\ @brief AXIMC master 6 write priority register
\ Address offset: 0x48104
\ Reset value: 0x00000004
\

$0000000f constant AXIMC_AXIMC_M6_WRITE_QOS_AW_QOS                  \ write channel QoS setting


\
\ @brief AXIMC master 6 issuing capability override functionality register
\ Address offset: 0x48108
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_AXIMC_M6_FN_MOD_READ_ISS_OVERRIDE          \ override AMIB read issuing capability
$00000002 constant AXIMC_AXIMC_M6_FN_MOD_WRITE_ISS_OVERRIDE         \ override AMIB write issuing capability


\
\ @brief AXIMC master 7 read priority register
\ Address offset: 0x49100
\ Reset value: 0x00000008
\

$0000000f constant AXIMC_AXIMC_M7_READ_QOS_AR_QOS                   \ read channel QoS setting


\
\ @brief AXIMC master 7 write priority register
\ Address offset: 0x49104
\ Reset value: 0x00000008
\

$0000000f constant AXIMC_AXIMC_M7_WRITE_QOS_AW_QOS                  \ write channel QoS setting


\
\ @brief AXIMC master 7 issuing capability override functionality register
\ Address offset: 0x49108
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_AXIMC_M7_FN_MOD_READ_ISS_OVERRIDE          \ override AMIB read issuing capability
$00000002 constant AXIMC_AXIMC_M7_FN_MOD_WRITE_ISS_OVERRIDE         \ override AMIB write issuing capability


\
\ @brief AXIMC master 8 read priority register
\ Address offset: 0x4A100
\ Reset value: 0x00000008
\

$0000000f constant AXIMC_AXIMC_M8_READ_QOS_AR_QOS                   \ read channel QoS setting


\
\ @brief AXIMC master 8 write priority register
\ Address offset: 0x4A104
\ Reset value: 0x00000008
\

$0000000f constant AXIMC_AXIMC_M8_WRITE_QOS_AW_QOS                  \ write channel QoS setting


\
\ @brief AXIMC master 8 issuing capability override functionality register
\ Address offset: 0x4A108
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_AXIMC_M8_FN_MOD_READ_ISS_OVERRIDE          \ override AMIB read issuing capability
$00000002 constant AXIMC_AXIMC_M8_FN_MOD_WRITE_ISS_OVERRIDE         \ override AMIB write issuing capability


\
\ @brief AXIMC master 9 read priority register
\ Address offset: 0x4B100
\ Reset value: 0x00000002
\

$0000000f constant AXIMC_AXIMC_M9_READ_QOS_AR_QOS                   \ read channel QoS setting


\
\ @brief AXIMC master 9 write priority register
\ Address offset: 0x4B104
\ Reset value: 0x00000002
\

$0000000f constant AXIMC_AXIMC_M9_WRITE_QOS_AW_QOS                  \ write channel QoS setting


\
\ @brief AXIMC master 9 issuing capability override functionality register
\ Address offset: 0x4B108
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_AXIMC_M9_FN_MOD_READ_ISS_OVERRIDE          \ override AMIB read issuing capability
$00000002 constant AXIMC_AXIMC_M9_FN_MOD_WRITE_ISS_OVERRIDE         \ override AMIB write issuing capability


\
\ @brief AXIMC master 10 read priority register
\ Address offset: 0x4C100
\ Reset value: 0x00000002
\

$0000000f constant AXIMC_AXIMC_M10_READ_QOS_AR_QOS                  \ read channel QoS setting


\
\ @brief AXIMC master 10 write priority register
\ Address offset: 0x4C104
\ Reset value: 0x00000002
\

$0000000f constant AXIMC_AXIMC_M10_WRITE_QOS_AW_QOS                 \ write channel QoS setting


\
\ @brief AXIMC master 10 issuing capability override functionality register
\ Address offset: 0x4C108
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_AXIMC_M10_FN_MOD_READ_ISS_OVERRIDE         \ override AMIB read issuing capability
$00000002 constant AXIMC_AXIMC_M10_FN_MOD_WRITE_ISS_OVERRIDE        \ override AMIB write issuing capability


\
\ @brief AXIMC master 11 read priority register
\ Address offset: 0x4D100
\ Reset value: 0x00000002
\

$0000000f constant AXIMC_AXIMC_M11_READ_QOS_AR_QOS                  \ read channel QoS setting


\
\ @brief AXIMC master 11 write priority register
\ Address offset: 0x4D104
\ Reset value: 0x00000002
\

$0000000f constant AXIMC_AXIMC_M11_WRITE_QOS_AW_QOS                 \ write channel QoS setting


\
\ @brief AXIMC master 11 issuing capability override functionality register
\ Address offset: 0x4D108
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_AXIMC_M11_FN_MOD_READ_ISS_OVERRIDE         \ override AMIB read issuing capability
$00000002 constant AXIMC_AXIMC_M11_FN_MOD_WRITE_ISS_OVERRIDE        \ override AMIB write issuing capability


\
\ @brief AXIMC
\
$57001fd0 constant AXIMC_AXIMC_PERIPH_ID_4  \ offset: 0x1FD0 : AXIMC peripheral ID4 register
$57001fd4 constant AXIMC_AXIMC_PERIPH_ID_5  \ offset: 0x1FD4 : AXIMC peripheral ID5 register
$57001fd8 constant AXIMC_AXIMC_PERIPH_ID_6  \ offset: 0x1FD8 : AXIMC peripheral ID6 register
$57001fdc constant AXIMC_AXIMC_PERIPH_ID_7  \ offset: 0x1FDC : AXIMC peripheral ID7 register
$57001fe0 constant AXIMC_AXIMC_PERIPH_ID_0  \ offset: 0x1FE0 : AXIMC peripheral ID0 register
$57001fe4 constant AXIMC_AXIMC_PERIPH_ID_1  \ offset: 0x1FE4 : AXIMC peripheral ID1 register
$57001fe8 constant AXIMC_AXIMC_PERIPH_ID_2  \ offset: 0x1FE8 : AXIMC peripheral ID2 register
$57001fec constant AXIMC_AXIMC_PERIPH_ID_3  \ offset: 0x1FEC : AXIMC peripheral ID3 register
$57001ff0 constant AXIMC_AXIMC_COMP_ID_0  \ offset: 0x1FF0 : AXIMC component ID0 register
$57001ff4 constant AXIMC_AXIMC_COMP_ID_1  \ offset: 0x1FF4 : AXIMC component ID1 register
$57001ff8 constant AXIMC_AXIMC_COMP_ID_2  \ offset: 0x1FF8 : AXIMC component ID2 register
$57001ffc constant AXIMC_AXIMC_COMP_ID_3  \ offset: 0x1FFC : AXIMC component ID3 register
$57042024 constant AXIMC_AXIMC_M0_FN_MOD2  \ offset: 0x42024 : AXIMC master 0 packing functionality register
$57042028 constant AXIMC_AXIMC_M0_FN_MOD_AHB  \ offset: 0x42028 : AXIMC master 0 AHB conversion override functionality register
$57042100 constant AXIMC_AXIMC_M0_READ_QOS  \ offset: 0x42100 : AXIMC master 0 read priority register
$57042104 constant AXIMC_AXIMC_M0_WRITE_QOS  \ offset: 0x42104 : AXIMC master 0 write priority register
$57042108 constant AXIMC_AXIMC_M0_FN_MOD  \ offset: 0x42108 : AXIMC master 0 issuing capability override functionality register
$57043024 constant AXIMC_AXIMC_M1_FN_MOD2  \ offset: 0x43024 : AXIMC master 1 packing functionality register
$57043028 constant AXIMC_AXIMC_M1_FN_MOD_AHB  \ offset: 0x43028 : AXIMC master 1 AHB conversion override functionality register
$57043100 constant AXIMC_AXIMC_M1_READ_QOS  \ offset: 0x43100 : AXIMC master 1 read priority register
$57043104 constant AXIMC_AXIMC_M1_WRITE_QOS  \ offset: 0x43104 : AXIMC master 1 write priority register
$57043108 constant AXIMC_AXIMC_M1_FN_MOD  \ offset: 0x43108 : AXIMC master 1 issuing capability override functionality register
$57044024 constant AXIMC_AXIMC_M2_FN_MOD2  \ offset: 0x44024 : AXIMC master 2 packing functionality register
$57044028 constant AXIMC_AXIMC_M2_FN_MOD_AHB  \ offset: 0x44028 : AXIMC master 2 AHB conversion override functionality register
$57044100 constant AXIMC_AXIMC_M2_READ_QOS  \ offset: 0x44100 : AXIMC master 2 read priority register
$57044104 constant AXIMC_AXIMC_M2_WRITE_QOS  \ offset: 0x44104 : AXIMC master 2 write priority register
$57044108 constant AXIMC_AXIMC_M2_FN_MOD  \ offset: 0x44108 : AXIMC master 2 issuing capability override functionality register
$57045100 constant AXIMC_AXIMC_M3_READ_QOS  \ offset: 0x45100 : AXIMC master 3 read priority register
$57045104 constant AXIMC_AXIMC_M3_WRITE_QOS  \ offset: 0x45104 : AXIMC master 3 write priority register
$57045108 constant AXIMC_AXIMC_M3_FN_MOD  \ offset: 0x45108 : AXIMC master 3 packing functionality register
$5704602c constant AXIMC_AXIMC_M4_FN_MOD_LB  \ offset: 0x4602C : AXIMC long burst capability inhibition register
$57046100 constant AXIMC_AXIMC_M4_READ_QOS  \ offset: 0x46100 : AXIMC master 4 read priority register
$57046104 constant AXIMC_AXIMC_M4_WRITE_QOS  \ offset: 0x46104 : AXIMC master 4 write priority register
$57046108 constant AXIMC_AXIMC_M4_FN_MOD  \ offset: 0x46108 : AXIMC master 4 packing functionality register
$57047024 constant AXIMC_AXIMC_M5_FN_MOD2  \ offset: 0x47024 : AXIMC master 5 packing functionality register
$57047028 constant AXIMC_AXIMC_M5_FN_MOD_AHB  \ offset: 0x47028 : AXIMC master 5 AHB conversion override functionality register
$57047100 constant AXIMC_AXIMC_M5_READ_QOS  \ offset: 0x47100 : AXIMC master 5 read priority register
$57047104 constant AXIMC_AXIMC_M5_WRITE_QOS  \ offset: 0x47104 : AXIMC master 5 write priority register
$57047108 constant AXIMC_AXIMC_M5_FN_MOD  \ offset: 0x47108 : AXIMC master 5 issuing capability override functionality register
$57048024 constant AXIMC_AXIMC_M6_FN_MOD2  \ offset: 0x48024 : AXIMC master 6 packing functionality register
$57048028 constant AXIMC_AXIMC_M6_FN_MOD_AHB  \ offset: 0x48028 : AXIMC master 6 AHB conversion override functionality register
$57048100 constant AXIMC_AXIMC_M6_READ_QOS  \ offset: 0x48100 : AXIMC master 6 read priority register
$57048104 constant AXIMC_AXIMC_M6_WRITE_QOS  \ offset: 0x48104 : AXIMC master 6 write priority register
$57048108 constant AXIMC_AXIMC_M6_FN_MOD  \ offset: 0x48108 : AXIMC master 6 issuing capability override functionality register
$57049100 constant AXIMC_AXIMC_M7_READ_QOS  \ offset: 0x49100 : AXIMC master 7 read priority register
$57049104 constant AXIMC_AXIMC_M7_WRITE_QOS  \ offset: 0x49104 : AXIMC master 7 write priority register
$57049108 constant AXIMC_AXIMC_M7_FN_MOD  \ offset: 0x49108 : AXIMC master 7 issuing capability override functionality register
$5704a100 constant AXIMC_AXIMC_M8_READ_QOS  \ offset: 0x4A100 : AXIMC master 8 read priority register
$5704a104 constant AXIMC_AXIMC_M8_WRITE_QOS  \ offset: 0x4A104 : AXIMC master 8 write priority register
$5704a108 constant AXIMC_AXIMC_M8_FN_MOD  \ offset: 0x4A108 : AXIMC master 8 issuing capability override functionality register
$5704b100 constant AXIMC_AXIMC_M9_READ_QOS  \ offset: 0x4B100 : AXIMC master 9 read priority register
$5704b104 constant AXIMC_AXIMC_M9_WRITE_QOS  \ offset: 0x4B104 : AXIMC master 9 write priority register
$5704b108 constant AXIMC_AXIMC_M9_FN_MOD  \ offset: 0x4B108 : AXIMC master 9 issuing capability override functionality register
$5704c100 constant AXIMC_AXIMC_M10_READ_QOS  \ offset: 0x4C100 : AXIMC master 10 read priority register
$5704c104 constant AXIMC_AXIMC_M10_WRITE_QOS  \ offset: 0x4C104 : AXIMC master 10 write priority register
$5704c108 constant AXIMC_AXIMC_M10_FN_MOD  \ offset: 0x4C108 : AXIMC master 10 issuing capability override functionality register
$5704d100 constant AXIMC_AXIMC_M11_READ_QOS  \ offset: 0x4D100 : AXIMC master 11 read priority register
$5704d104 constant AXIMC_AXIMC_M11_WRITE_QOS  \ offset: 0x4D104 : AXIMC master 11 write priority register
$5704d108 constant AXIMC_AXIMC_M11_FN_MOD  \ offset: 0x4D108 : AXIMC master 11 issuing capability override functionality register

