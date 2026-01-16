\
\ @file aximc_mx.fs
\ @brief AXIMC_Mx
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief AXIMC master 0 packing functionality register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_MX_AXIMC_M0_FN_MOD2_BYPASS_MERGE           \ BYPASS_MERGE


\
\ @brief AXIMC master 0 read priority register
\ Address offset: 0xDC
\ Reset value: 0x00000006
\

$0000000f constant AXIMC_MX_AXIMC_M0_READ_QOS_AR_QOS                \ AR_QOS


\
\ @brief AXIMC master 0 issuing capability override functionality register
\ Address offset: 0xE0
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_MX_AXIMC_M0_FN_MOD_READ_ISS_OVERRIDE       \ READ_ISS_OVERRIDE
$00000002 constant AXIMC_MX_AXIMC_M0_FN_MOD_WRITE_ISS_OVERRIDE      \ WRITE_ISS_OVERRIDE


\
\ @brief AXIMC master 0 write priority register
\ Address offset: 0xE4
\ Reset value: 0x00000006
\

$0000000f constant AXIMC_MX_AXIMC_M0_WRITE_QOS_AW_QOS               \ AW_QOS


\
\ @brief AXIMC master 1 packing functionality register
\ Address offset: 0x1000
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_MX_AXIMC_M1_FN_MOD2_BYPASS_MERGE           \ BYPASS_MERGE


\
\ @brief AXIMC master 1 read priority register
\ Address offset: 0x10DC
\ Reset value: 0x00000006
\

$0000000f constant AXIMC_MX_AXIMC_M1_READ_QOS_AR_QOS                \ AR_QOS


\
\ @brief AXIMC master 1 write priority register
\ Address offset: 0x10E0
\ Reset value: 0x00000006
\

$0000000f constant AXIMC_MX_AXIMC_M1_WRITE_QOS_AW_QOS               \ AW_QOS


\
\ @brief AXIMC master 1 issuing capability override functionality register
\ Address offset: 0x10E4
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_MX_AXIMC_M1_FN_MOD_READ_ISS_OVERRIDE       \ READ_ISS_OVERRIDE
$00000002 constant AXIMC_MX_AXIMC_M1_FN_MOD_WRITE_ISS_OVERRIDE      \ WRITE_ISS_OVERRIDE


\
\ @brief AXIMC peripheral ID4 register
\ Address offset: 0x1FD0
\ Reset value: 0x00000004
\

$0000000f constant AXIMC_MX_AXIMC_PERIPH_ID_4_JEP106CON             \ JEP106CON
$000000f0 constant AXIMC_MX_AXIMC_PERIPH_ID_4_K4COUNT               \ K4COUNT


\
\ @brief AXIMC peripheral ID5 register
\ Address offset: 0x1FD4
\ Reset value: 0x00000000
\

$000000ff constant AXIMC_MX_AXIMC_PERIPH_ID_5_PERIPH_ID_5           \ PERIPH_ID_5


\
\ @brief AXIMC peripheral ID6 register
\ Address offset: 0x1FD8
\ Reset value: 0x00000000
\

$000000ff constant AXIMC_MX_AXIMC_PERIPH_ID_6_PERIPH_ID_6           \ PERIPH_ID_6


\
\ @brief AXIMC peripheral ID7 register
\ Address offset: 0x1FDC
\ Reset value: 0x00000000
\

$000000ff constant AXIMC_MX_AXIMC_PERIPH_ID_7_PERIPH_ID_7           \ PERIPH_ID_7


\
\ @brief AXIMC peripheral ID0 register
\ Address offset: 0x1FE0
\ Reset value: 0x00000000
\

$000000ff constant AXIMC_MX_AXIMC_PERIPH_ID_0_PERIPH_ID_0           \ PERIPH_ID_0


\
\ @brief AXIMC peripheral ID1 register
\ Address offset: 0x1FE4
\ Reset value: 0x000000B4
\

$000000ff constant AXIMC_MX_AXIMC_PERIPH_ID_1_PERIPH_ID_1           \ PERIPH_ID_1


\
\ @brief AXIMC peripheral ID2 register
\ Address offset: 0x1FE8
\ Reset value: 0x0000003B
\

$000000ff constant AXIMC_MX_AXIMC_PERIPH_ID_2_PERIPH_ID_2           \ PERIPH_ID_2


\
\ @brief AXIMC peripheral ID3 register
\ Address offset: 0x1FEC
\ Reset value: 0x00000000
\

$0000000f constant AXIMC_MX_AXIMC_PERIPH_ID_3_CUST_MOD_NUM          \ CUST_MOD_NUM
$000000f0 constant AXIMC_MX_AXIMC_PERIPH_ID_3_REV_AND               \ REV_AND


\
\ @brief AXIMC component ID0 register
\ Address offset: 0x1FF0
\ Reset value: 0x0000000D
\

$000000ff constant AXIMC_MX_AXIMC_COMP_ID_0_PREAMBLE                \ PREAMBLE


\
\ @brief AXIMC component ID1 register
\ Address offset: 0x1FF4
\ Reset value: 0x000000F0
\

$0000000f constant AXIMC_MX_AXIMC_COMP_ID_1_PREAMBLE                \ PREAMBLE
$000000f0 constant AXIMC_MX_AXIMC_COMP_ID_1_CLASS                   \ CLASS


\
\ @brief AXIMC component ID2 register
\ Address offset: 0x1FF8
\ Reset value: 0x00000005
\

$000000ff constant AXIMC_MX_AXIMC_COMP_ID_2_PREAMBLE                \ PREAMBLE


\
\ @brief AXIMC component ID3 register
\ Address offset: 0x1FFC
\ Reset value: 0x000000B1
\

$000000ff constant AXIMC_MX_AXIMC_COMP_ID_3_PREAMBLE                \ PREAMBLE


\
\ @brief AXIMC master 2 packing functionality register
\ Address offset: 0x2000
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_MX_AXIMC_M2_FN_MOD2_BYPASS_MERGE           \ BYPASS_MERGE


\
\ @brief AXIMC master 2 read priority register
\ Address offset: 0x20DC
\ Reset value: 0x00000006
\

$0000000f constant AXIMC_MX_AXIMC_M2_READ_QOS_AR_QOS                \ AR_QOS


\
\ @brief AXIMC master 2 write priority register
\ Address offset: 0x20E0
\ Reset value: 0x00000006
\

$0000000f constant AXIMC_MX_AXIMC_M2_WRITE_QOS_AW_QOS               \ AW_QOS


\
\ @brief AXIMC master 2 issuing capability override functionality register
\ Address offset: 0x20E4
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_MX_AXIMC_M2_FN_MOD_READ_ISS_OVERRIDE       \ READ_ISS_OVERRIDE
$00000002 constant AXIMC_MX_AXIMC_M2_FN_MOD_WRITE_ISS_OVERRIDE      \ WRITE_ISS_OVERRIDE


\
\ @brief AXIMC master 5 packing functionality register
\ Address offset: 0x3000
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_MX_AXIMC_M5_FN_MOD2_BYPASS_MERGE           \ BYPASS_MERGE


\
\ @brief AXIMC master 5 read priority register
\ Address offset: 0x30DC
\ Reset value: 0x00000004
\

$0000000f constant AXIMC_MX_AXIMC_M5_READ_QOS_AR_QOS                \ AR_QOS


\
\ @brief AXIMC master 5 write priority register
\ Address offset: 0x30E0
\ Reset value: 0x00000004
\

$0000000f constant AXIMC_MX_AXIMC_M5_WRITE_QOS_AW_QOS               \ AW_QOS


\
\ @brief AXIMC master 5 issuing capability override functionality register
\ Address offset: 0x30E4
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_MX_AXIMC_M5_FN_MOD_READ_ISS_OVERRIDE       \ READ_ISS_OVERRIDE
$00000002 constant AXIMC_MX_AXIMC_M5_FN_MOD_WRITE_ISS_OVERRIDE      \ WRITE_ISS_OVERRIDE


\
\ @brief AXIMC master 3 read priority register
\ Address offset: 0x40DC
\ Reset value: 0x00000007
\

$0000000f constant AXIMC_MX_AXIMC_M3_READ_QOS_AR_QOS                \ AR_QOS


\
\ @brief AXIMC master 3 write priority register
\ Address offset: 0x40E0
\ Reset value: 0x00000007
\

$0000000f constant AXIMC_MX_AXIMC_M3_WRITE_QOS_AW_QOS               \ AW_QOS


\
\ @brief AXIMC master 3 packing functionality register
\ Address offset: 0x40E4
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_MX_AXIMC_M3_FN_MOD_READ_ISS_OVERRIDE       \ READ_ISS_OVERRIDE
$00000002 constant AXIMC_MX_AXIMC_M3_FN_MOD_WRITE_ISS_OVERRIDE      \ WRITE_ISS_OVERRIDE


\
\ @brief AXIMC master 7 read priority register
\ Address offset: 0x50DC
\ Reset value: 0x00000008
\

$0000000f constant AXIMC_MX_AXIMC_M7_READ_QOS_AR_QOS                \ AR_QOS


\
\ @brief AXIMC master 7 write priority register
\ Address offset: 0x50E0
\ Reset value: 0x00000008
\

$0000000f constant AXIMC_MX_AXIMC_M7_WRITE_QOS_AW_QOS               \ AW_QOS


\
\ @brief AXIMC master 7 issuing capability override functionality register
\ Address offset: 0x50E4
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_MX_AXIMC_M7_FN_MOD_READ_ISS_OVERRIDE       \ READ_ISS_OVERRIDE
$00000002 constant AXIMC_MX_AXIMC_M7_FN_MOD_WRITE_ISS_OVERRIDE      \ WRITE_ISS_OVERRIDE


\
\ @brief AXIMC master 8 read priority register
\ Address offset: 0x60DC
\ Reset value: 0x00000008
\

$0000000f constant AXIMC_MX_AXIMC_M8_READ_QOS_AR_QOS                \ AR_QOS


\
\ @brief AXIMC master 8 write priority register
\ Address offset: 0x60E0
\ Reset value: 0x00000008
\

$0000000f constant AXIMC_MX_AXIMC_M8_WRITE_QOS_AW_QOS               \ AW_QOS


\
\ @brief AXIMC master 8 issuing capability override functionality register
\ Address offset: 0x60E4
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_MX_AXIMC_M8_FN_MOD_READ_ISS_OVERRIDE       \ READ_ISS_OVERRIDE
$00000002 constant AXIMC_MX_AXIMC_M8_FN_MOD_WRITE_ISS_OVERRIDE      \ WRITE_ISS_OVERRIDE


\
\ @brief AXIMC master 4 packing functionality register
\ Address offset: 0x8000
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_MX_AXIMC_M4_FN_MOD2_BYPASS_MERGE           \ BYPASS_MERGE


\
\ @brief AXIMC master 4 read priority register
\ Address offset: 0x80DC
\ Reset value: 0x00000007
\

$0000000f constant AXIMC_MX_AXIMC_M4_READ_QOS_AR_QOS                \ AR_QOS


\
\ @brief AXIMC master 4 write priority register
\ Address offset: 0x80E0
\ Reset value: 0x00000007
\

$0000000f constant AXIMC_MX_AXIMC_M4_WRITE_QOS_AW_QOS               \ AW_QOS


\
\ @brief AXIMC master 4 packing functionality register
\ Address offset: 0x80E4
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_MX_AXIMC_M4_FN_MOD_READ_ISS_OVERRIDE       \ READ_ISS_OVERRIDE
$00000002 constant AXIMC_MX_AXIMC_M4_FN_MOD_WRITE_ISS_OVERRIDE      \ WRITE_ISS_OVERRIDE


\
\ @brief AXIMC master 9 read priority register
\ Address offset: 0x90DC
\ Reset value: 0x0000000B
\

$0000000f constant AXIMC_MX_AXIMC_M9_READ_QOS_AR_QOS                \ AR_QOS


\
\ @brief AXIMC master 9 write priority register
\ Address offset: 0x90E0
\ Reset value: 0x0000000B
\

$0000000f constant AXIMC_MX_AXIMC_M9_WRITE_QOS_AW_QOS               \ AW_QOS


\
\ @brief AXIMC master 9 issuing capability override functionality register
\ Address offset: 0x90E4
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_MX_AXIMC_M9_FN_MOD_READ_ISS_OVERRIDE       \ READ_ISS_OVERRIDE
$00000002 constant AXIMC_MX_AXIMC_M9_FN_MOD_WRITE_ISS_OVERRIDE      \ WRITE_ISS_OVERRIDE


\
\ @brief AXIMC master 10 read priority register
\ Address offset: 0xA0DC
\ Reset value: 0x0000000B
\

$0000000f constant AXIMC_MX_AXIMC_M10_READ_QOS_AR_QOS               \ AR_QOS


\
\ @brief AXIMC master 10 write priority register
\ Address offset: 0xA0E0
\ Reset value: 0x0000000B
\

$0000000f constant AXIMC_MX_AXIMC_M10_WRITE_QOS_AW_QOS              \ AW_QOS


\
\ @brief AXIMC master 10 issuing capability override functionality register
\ Address offset: 0xA0E4
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_MX_AXIMC_M10_FN_MOD_READ_ISS_OVERRIDE      \ READ_ISS_OVERRIDE
$00000002 constant AXIMC_MX_AXIMC_M10_FN_MOD_WRITE_ISS_OVERRIDE     \ WRITE_ISS_OVERRIDE


\
\ @brief AXIMC master 6 packing functionality register
\ Address offset: 0xB000
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_MX_AXIMC_M6_FN_MOD2_BYPASS_MERGE           \ BYPASS_MERGE


\
\ @brief AXIMC master 6 read priority register
\ Address offset: 0xB0DC
\ Reset value: 0x00000004
\

$0000000f constant AXIMC_MX_AXIMC_M6_READ_QOS_AR_QOS                \ AR_QOS


\
\ @brief AXIMC master 6 write priority register
\ Address offset: 0xB0E0
\ Reset value: 0x00000004
\

$0000000f constant AXIMC_MX_AXIMC_M6_WRITE_QOS_AW_QOS               \ AW_QOS


\
\ @brief AXIMC master 6 issuing capability override functionality register
\ Address offset: 0xB0E4
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_MX_AXIMC_M6_FN_MOD_READ_ISS_OVERRIDE       \ READ_ISS_OVERRIDE
$00000002 constant AXIMC_MX_AXIMC_M6_FN_MOD_WRITE_ISS_OVERRIDE      \ WRITE_ISS_OVERRIDE


\
\ @brief AXIMC master 0 AHB conversion override functionality register
\ Address offset: 0x42028
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_MX_AXIMC_M0_FN_MOD_AHB_RD_INC_OVERRIDE     \ RD_INC_OVERRIDE
$00000002 constant AXIMC_MX_AXIMC_M0_FN_MOD_AHB_WR_INC_OVERRIDE     \ WR_INC_OVERRIDE


\
\ @brief AXIMC master 1 AHB conversion override functionality register
\ Address offset: 0x43028
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_MX_AXIMC_M1_FN_MOD_AHB_RD_INC_OVERRIDE     \ RD_INC_OVERRIDE
$00000002 constant AXIMC_MX_AXIMC_M1_FN_MOD_AHB_WR_INC_OVERRIDE     \ WR_INC_OVERRIDE


\
\ @brief AXIMC master 2 AHB conversion override functionality register
\ Address offset: 0x44028
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_MX_AXIMC_M2_FN_MOD_AHB_RD_INC_OVERRIDE     \ RD_INC_OVERRIDE
$00000002 constant AXIMC_MX_AXIMC_M2_FN_MOD_AHB_WR_INC_OVERRIDE     \ WR_INC_OVERRIDE


\
\ @brief AXIMC master 5 AHB conversion override functionality register
\ Address offset: 0x45028
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_MX_AXIMC_M5_FN_MOD_AHB_RD_INC_OVERRIDE     \ RD_INC_OVERRIDE
$00000002 constant AXIMC_MX_AXIMC_M5_FN_MOD_AHB_WR_INC_OVERRIDE     \ WR_INC_OVERRIDE


\
\ @brief AXIMC long burst capability inhibition register
\ Address offset: 0x4A02C
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_MX_AXIMC_FN_MOD_LB_FN_MOD_LB               \ FN_MOD_LB


\
\ @brief AXIMC master 6 AHB conversion override functionality register
\ Address offset: 0x4D028
\ Reset value: 0x00000000
\

$00000001 constant AXIMC_MX_AXIMC_M6_FN_MOD_AHB_RD_INC_OVERRIDE     \ RD_INC_OVERRIDE
$00000002 constant AXIMC_MX_AXIMC_M6_FN_MOD_AHB_WR_INC_OVERRIDE     \ WR_INC_OVERRIDE


\
\ @brief AXIMC_Mx
\
$57042024 constant AXIMC_MX_AXIMC_M0_FN_MOD2  \ offset: 0x00 : AXIMC master 0 packing functionality register
$57042100 constant AXIMC_MX_AXIMC_M0_READ_QOS  \ offset: 0xDC : AXIMC master 0 read priority register
$57042104 constant AXIMC_MX_AXIMC_M0_FN_MOD  \ offset: 0xE0 : AXIMC master 0 issuing capability override functionality register
$57042108 constant AXIMC_MX_AXIMC_M0_WRITE_QOS  \ offset: 0xE4 : AXIMC master 0 write priority register
$57043024 constant AXIMC_MX_AXIMC_M1_FN_MOD2  \ offset: 0x1000 : AXIMC master 1 packing functionality register
$57043100 constant AXIMC_MX_AXIMC_M1_READ_QOS  \ offset: 0x10DC : AXIMC master 1 read priority register
$57043104 constant AXIMC_MX_AXIMC_M1_WRITE_QOS  \ offset: 0x10E0 : AXIMC master 1 write priority register
$57043108 constant AXIMC_MX_AXIMC_M1_FN_MOD  \ offset: 0x10E4 : AXIMC master 1 issuing capability override functionality register
$57043ff4 constant AXIMC_MX_AXIMC_PERIPH_ID_4  \ offset: 0x1FD0 : AXIMC peripheral ID4 register
$57043ff8 constant AXIMC_MX_AXIMC_PERIPH_ID_5  \ offset: 0x1FD4 : AXIMC peripheral ID5 register
$57043ffc constant AXIMC_MX_AXIMC_PERIPH_ID_6  \ offset: 0x1FD8 : AXIMC peripheral ID6 register
$57044000 constant AXIMC_MX_AXIMC_PERIPH_ID_7  \ offset: 0x1FDC : AXIMC peripheral ID7 register
$57044004 constant AXIMC_MX_AXIMC_PERIPH_ID_0  \ offset: 0x1FE0 : AXIMC peripheral ID0 register
$57044008 constant AXIMC_MX_AXIMC_PERIPH_ID_1  \ offset: 0x1FE4 : AXIMC peripheral ID1 register
$5704400c constant AXIMC_MX_AXIMC_PERIPH_ID_2  \ offset: 0x1FE8 : AXIMC peripheral ID2 register
$57044010 constant AXIMC_MX_AXIMC_PERIPH_ID_3  \ offset: 0x1FEC : AXIMC peripheral ID3 register
$57044014 constant AXIMC_MX_AXIMC_COMP_ID_0  \ offset: 0x1FF0 : AXIMC component ID0 register
$57044018 constant AXIMC_MX_AXIMC_COMP_ID_1  \ offset: 0x1FF4 : AXIMC component ID1 register
$5704401c constant AXIMC_MX_AXIMC_COMP_ID_2  \ offset: 0x1FF8 : AXIMC component ID2 register
$57044020 constant AXIMC_MX_AXIMC_COMP_ID_3  \ offset: 0x1FFC : AXIMC component ID3 register
$57044024 constant AXIMC_MX_AXIMC_M2_FN_MOD2  \ offset: 0x2000 : AXIMC master 2 packing functionality register
$57044100 constant AXIMC_MX_AXIMC_M2_READ_QOS  \ offset: 0x20DC : AXIMC master 2 read priority register
$57044104 constant AXIMC_MX_AXIMC_M2_WRITE_QOS  \ offset: 0x20E0 : AXIMC master 2 write priority register
$57044108 constant AXIMC_MX_AXIMC_M2_FN_MOD  \ offset: 0x20E4 : AXIMC master 2 issuing capability override functionality register
$57045024 constant AXIMC_MX_AXIMC_M5_FN_MOD2  \ offset: 0x3000 : AXIMC master 5 packing functionality register
$57045100 constant AXIMC_MX_AXIMC_M5_READ_QOS  \ offset: 0x30DC : AXIMC master 5 read priority register
$57045104 constant AXIMC_MX_AXIMC_M5_WRITE_QOS  \ offset: 0x30E0 : AXIMC master 5 write priority register
$57045108 constant AXIMC_MX_AXIMC_M5_FN_MOD  \ offset: 0x30E4 : AXIMC master 5 issuing capability override functionality register
$57046100 constant AXIMC_MX_AXIMC_M3_READ_QOS  \ offset: 0x40DC : AXIMC master 3 read priority register
$57046104 constant AXIMC_MX_AXIMC_M3_WRITE_QOS  \ offset: 0x40E0 : AXIMC master 3 write priority register
$57046108 constant AXIMC_MX_AXIMC_M3_FN_MOD  \ offset: 0x40E4 : AXIMC master 3 packing functionality register
$57047100 constant AXIMC_MX_AXIMC_M7_READ_QOS  \ offset: 0x50DC : AXIMC master 7 read priority register
$57047104 constant AXIMC_MX_AXIMC_M7_WRITE_QOS  \ offset: 0x50E0 : AXIMC master 7 write priority register
$57047108 constant AXIMC_MX_AXIMC_M7_FN_MOD  \ offset: 0x50E4 : AXIMC master 7 issuing capability override functionality register
$57048100 constant AXIMC_MX_AXIMC_M8_READ_QOS  \ offset: 0x60DC : AXIMC master 8 read priority register
$57048104 constant AXIMC_MX_AXIMC_M8_WRITE_QOS  \ offset: 0x60E0 : AXIMC master 8 write priority register
$57048108 constant AXIMC_MX_AXIMC_M8_FN_MOD  \ offset: 0x60E4 : AXIMC master 8 issuing capability override functionality register
$5704a024 constant AXIMC_MX_AXIMC_M4_FN_MOD2  \ offset: 0x8000 : AXIMC master 4 packing functionality register
$5704a100 constant AXIMC_MX_AXIMC_M4_READ_QOS  \ offset: 0x80DC : AXIMC master 4 read priority register
$5704a104 constant AXIMC_MX_AXIMC_M4_WRITE_QOS  \ offset: 0x80E0 : AXIMC master 4 write priority register
$5704a108 constant AXIMC_MX_AXIMC_M4_FN_MOD  \ offset: 0x80E4 : AXIMC master 4 packing functionality register
$5704b100 constant AXIMC_MX_AXIMC_M9_READ_QOS  \ offset: 0x90DC : AXIMC master 9 read priority register
$5704b104 constant AXIMC_MX_AXIMC_M9_WRITE_QOS  \ offset: 0x90E0 : AXIMC master 9 write priority register
$5704b108 constant AXIMC_MX_AXIMC_M9_FN_MOD  \ offset: 0x90E4 : AXIMC master 9 issuing capability override functionality register
$5704c100 constant AXIMC_MX_AXIMC_M10_READ_QOS  \ offset: 0xA0DC : AXIMC master 10 read priority register
$5704c104 constant AXIMC_MX_AXIMC_M10_WRITE_QOS  \ offset: 0xA0E0 : AXIMC master 10 write priority register
$5704c108 constant AXIMC_MX_AXIMC_M10_FN_MOD  \ offset: 0xA0E4 : AXIMC master 10 issuing capability override functionality register
$5704d024 constant AXIMC_MX_AXIMC_M6_FN_MOD2  \ offset: 0xB000 : AXIMC master 6 packing functionality register
$5704d100 constant AXIMC_MX_AXIMC_M6_READ_QOS  \ offset: 0xB0DC : AXIMC master 6 read priority register
$5704d104 constant AXIMC_MX_AXIMC_M6_WRITE_QOS  \ offset: 0xB0E0 : AXIMC master 6 write priority register
$5704d108 constant AXIMC_MX_AXIMC_M6_FN_MOD  \ offset: 0xB0E4 : AXIMC master 6 issuing capability override functionality register
$5708404c constant AXIMC_MX_AXIMC_M0_FN_MOD_AHB  \ offset: 0x42028 : AXIMC master 0 AHB conversion override functionality register
$5708504c constant AXIMC_MX_AXIMC_M1_FN_MOD_AHB  \ offset: 0x43028 : AXIMC master 1 AHB conversion override functionality register
$5708604c constant AXIMC_MX_AXIMC_M2_FN_MOD_AHB  \ offset: 0x44028 : AXIMC master 2 AHB conversion override functionality register
$5708704c constant AXIMC_MX_AXIMC_M5_FN_MOD_AHB  \ offset: 0x45028 : AXIMC master 5 AHB conversion override functionality register
$5708c050 constant AXIMC_MX_AXIMC_FN_MOD_LB  \ offset: 0x4A02C : AXIMC long burst capability inhibition register
$5708f04c constant AXIMC_MX_AXIMC_M6_FN_MOD_AHB  \ offset: 0x4D028 : AXIMC master 6 AHB conversion override functionality register

