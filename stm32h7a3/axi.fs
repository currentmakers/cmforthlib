\
\ @file axi.fs
\ @brief AXI interconnect registers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief AXI interconnect - peripheral ID4 register
\ Address offset: 0x1FD0
\ Reset value: 0x00000004
\

$0000000f constant AXI_AXI_PERIPH_ID_4_JEP106CON                    \ JEP106 continuation code
$000000f0 constant AXI_AXI_PERIPH_ID_4_KCOUNT4                      \ Register file size


\
\ @brief AXI interconnect - peripheral ID0 register
\ Address offset: 0x1FE0
\ Reset value: 0x00000004
\

$000000ff constant AXI_AXI_PERIPH_ID_0_PARTNUM                      \ Peripheral part number bits 0 to 7


\
\ @brief AXI interconnect - peripheral ID1 register
\ Address offset: 0x1FE4
\ Reset value: 0x00000004
\

$0000000f constant AXI_AXI_PERIPH_ID_1_PARTNUM                      \ Peripheral part number bits 8 to 11
$000000f0 constant AXI_AXI_PERIPH_ID_1_JEP106I                      \ JEP106 identity bits 0 to 3


\
\ @brief AXI interconnect - peripheral ID2 register
\ Address offset: 0x1FE8
\ Reset value: 0x00000004
\

$00000007 constant AXI_AXI_PERIPH_ID_2_JEP106ID                     \ JEP106 Identity bits 4 to 6
$00000008 constant AXI_AXI_PERIPH_ID_2_JEDEC                        \ JEP106 code flag
$000000f0 constant AXI_AXI_PERIPH_ID_2_REVISION                     \ Peripheral revision number


\
\ @brief AXI interconnect - peripheral ID3 register
\ Address offset: 0x1FEC
\ Reset value: 0x00000004
\

$0000000f constant AXI_AXI_PERIPH_ID_3_CUST_MOD_NUM                 \ Customer modification
$000000f0 constant AXI_AXI_PERIPH_ID_3_REV_AND                      \ Customer version


\
\ @brief AXI interconnect - component ID0 register
\ Address offset: 0x1FF0
\ Reset value: 0x00000004
\

$000000ff constant AXI_AXI_COMP_ID_0_PREAMBLE                       \ Preamble bits 0 to 7


\
\ @brief AXI interconnect - component ID1 register
\ Address offset: 0x1FF4
\ Reset value: 0x00000004
\

$0000000f constant AXI_AXI_COMP_ID_1_PREAMBLE                       \ Preamble bits 8 to 11
$000000f0 constant AXI_AXI_COMP_ID_1_CLASS                          \ Component class


\
\ @brief AXI interconnect - component ID2 register
\ Address offset: 0x1FF8
\ Reset value: 0x00000004
\

$000000ff constant AXI_AXI_COMP_ID_2_PREAMBLE                       \ Preamble bits 12 to 19


\
\ @brief AXI interconnect - component ID3 register
\ Address offset: 0x1FFC
\ Reset value: 0x00000004
\

$000000ff constant AXI_AXI_COMP_ID_3_PREAMBLE                       \ Preamble bits 20 to 27


\
\ @brief AXI interconnect - TARG x bus matrix issuing functionality register
\ Address offset: 0x2008
\ Reset value: 0x00000004
\

$00000001 constant AXI_AXI_TARG1_FN_MOD_ISS_BM_READ_ISS_OVERRIDE    \ READ_ISS_OVERRIDE
$00000002 constant AXI_AXI_TARG1_FN_MOD_ISS_BM_WRITE_ISS_OVERRIDE    \ Switch matrix write issuing override for target


\
\ @brief AXI interconnect - TARG x bus matrix functionality 2 register
\ Address offset: 0x2024
\ Reset value: 0x00000004
\

$00000001 constant AXI_AXI_TARG1_FN_MOD2_BYPASS_MERGE               \ Disable packing of beats to match the output data width


\
\ @brief AXI interconnect - TARG x long burst functionality modification
\ Address offset: 0x202C
\ Reset value: 0x00000004
\

$00000001 constant AXI_AXI_TARG1_FN_MOD_LB_FN_MOD_LB                \ Controls burst breaking of long bursts


\
\ @brief AXI interconnect - TARG x long burst functionality modification
\ Address offset: 0x2108
\ Reset value: 0x00000004
\

$00000001 constant AXI_AXI_TARG1_FN_MOD_READ_ISS_OVERRIDE           \ Override AMIB read issuing capability
$00000002 constant AXI_AXI_TARG1_FN_MOD_WRITE_ISS_OVERRIDE          \ Override AMIB write issuing capability


\
\ @brief AXI interconnect - TARG x bus matrix issuing functionality register
\ Address offset: 0x3008
\ Reset value: 0x00000004
\

$00000001 constant AXI_AXI_TARG2_FN_MOD_ISS_BM_READ_ISS_OVERRIDE    \ READ_ISS_OVERRIDE
$00000002 constant AXI_AXI_TARG2_FN_MOD_ISS_BM_WRITE_ISS_OVERRIDE    \ Switch matrix write issuing override for target


\
\ @brief AXI interconnect - TARG x bus matrix functionality 2 register
\ Address offset: 0x3024
\ Reset value: 0x00000004
\

$00000001 constant AXI_AXI_TARG2_FN_MOD2_BYPASS_MERGE               \ Disable packing of beats to match the output data width


\
\ @brief AXI interconnect - TARG x long burst functionality modification
\ Address offset: 0x302C
\ Reset value: 0x00000004
\

$00000001 constant AXI_AXI_TARG2_FN_MOD_LB_FN_MOD_LB                \ Controls burst breaking of long bursts


\
\ @brief AXI interconnect - TARG x long burst functionality modification
\ Address offset: 0x3108
\ Reset value: 0x00000004
\

$00000001 constant AXI_AXI_TARG2_FN_MOD_READ_ISS_OVERRIDE           \ Override AMIB read issuing capability
$00000002 constant AXI_AXI_TARG2_FN_MOD_WRITE_ISS_OVERRIDE          \ Override AMIB write issuing capability


\
\ @brief AXI interconnect - TARG x bus matrix issuing functionality register
\ Address offset: 0x4008
\ Reset value: 0x00000004
\

$00000001 constant AXI_AXI_TARG3_FN_MOD_ISS_BM_READ_ISS_OVERRIDE    \ READ_ISS_OVERRIDE
$00000002 constant AXI_AXI_TARG3_FN_MOD_ISS_BM_WRITE_ISS_OVERRIDE    \ Switch matrix write issuing override for target


\
\ @brief AXI interconnect - TARG x bus matrix issuing functionality register
\ Address offset: 0x5008
\ Reset value: 0x00000004
\

$00000001 constant AXI_AXI_TARG4_FN_MOD_ISS_BM_READ_ISS_OVERRIDE    \ READ_ISS_OVERRIDE
$00000002 constant AXI_AXI_TARG4_FN_MOD_ISS_BM_WRITE_ISS_OVERRIDE    \ Switch matrix write issuing override for target


\
\ @brief AXI interconnect - TARG x bus matrix issuing functionality register
\ Address offset: 0x6008
\ Reset value: 0x00000004
\

$00000001 constant AXI_AXI_TARG5_FN_MOD_ISS_BM_READ_ISS_OVERRIDE    \ READ_ISS_OVERRIDE
$00000002 constant AXI_AXI_TARG5_FN_MOD_ISS_BM_WRITE_ISS_OVERRIDE    \ Switch matrix write issuing override for target


\
\ @brief AXI interconnect - TARG x bus matrix issuing functionality register
\ Address offset: 0x7008
\ Reset value: 0x00000004
\

$00000001 constant AXI_AXI_TARG6_FN_MOD_ISS_BM_READ_ISS_OVERRIDE    \ READ_ISS_OVERRIDE
$00000002 constant AXI_AXI_TARG6_FN_MOD_ISS_BM_WRITE_ISS_OVERRIDE    \ Switch matrix write issuing override for target


\
\ @brief AXI interconnect - TARG x bus matrix issuing functionality register
\ Address offset: 0x800C
\ Reset value: 0x00000004
\

$00000001 constant AXI_AXI_TARG7_FN_MOD_ISS_BM_READ_ISS_OVERRIDE    \ READ_ISS_OVERRIDE
$00000002 constant AXI_AXI_TARG7_FN_MOD_ISS_BM_WRITE_ISS_OVERRIDE    \ Switch matrix write issuing override for target


\
\ @brief AXI interconnect - TARG x bus matrix functionality 2 register
\ Address offset: 0x8024
\ Reset value: 0x00000004
\

$00000001 constant AXI_AXI_TARG7_FN_MOD2_BYPASS_MERGE               \ Disable packing of beats to match the output data width


\
\ @brief AXI interconnect - TARG x long burst functionality modification
\ Address offset: 0x8108
\ Reset value: 0x00000004
\

$00000001 constant AXI_AXI_TARG7_FN_MOD_READ_ISS_OVERRIDE           \ Override AMIB read issuing capability
$00000002 constant AXI_AXI_TARG7_FN_MOD_WRITE_ISS_OVERRIDE          \ Override AMIB write issuing capability


\
\ @brief AXI interconnect - INI x functionality modification 2 register
\ Address offset: 0x42024
\ Reset value: 0x00000004
\

$00000001 constant AXI_AXI_INI1_FN_MOD2_BYPASS_MERGE                \ Disables alteration of transactions by the up-sizer unless required by the protocol


\
\ @brief AXI interconnect - INI x AHB functionality modification register
\ Address offset: 0x42028
\ Reset value: 0x00000004
\

$00000001 constant AXI_AXI_INI1_FN_MOD_AHB_RD_INC_OVERRIDE          \ Converts all AHB-Lite write transactions to a series of single beat AXI
$00000002 constant AXI_AXI_INI1_FN_MOD_AHB_WR_INC_OVERRIDE          \ Converts all AHB-Lite read transactions to a series of single beat AXI


\
\ @brief AXI interconnect - INI x read QoS register
\ Address offset: 0x42100
\ Reset value: 0x00000004
\

$0000000f constant AXI_AXI_INI1_READ_QOS_AR_QOS                     \ Read channel QoS setting


\
\ @brief AXI interconnect - INI x write QoS register
\ Address offset: 0x42104
\ Reset value: 0x00000004
\

$0000000f constant AXI_AXI_INI1_WRITE_QOS_AW_QOS                    \ Write channel QoS setting


\
\ @brief AXI interconnect - INI x issuing functionality modification register
\ Address offset: 0x42108
\ Reset value: 0x00000004
\

$00000001 constant AXI_AXI_INI1_FN_MOD_READ_ISS_OVERRIDE            \ Override ASIB read issuing capability
$00000002 constant AXI_AXI_INI1_FN_MOD_WRITE_ISS_OVERRIDE           \ Override ASIB write issuing capability


\
\ @brief AXI interconnect - INI x read QoS register
\ Address offset: 0x43100
\ Reset value: 0x00000004
\

$0000000f constant AXI_AXI_INI2_READ_QOS_AR_QOS                     \ Read channel QoS setting


\
\ @brief AXI interconnect - INI x write QoS register
\ Address offset: 0x43104
\ Reset value: 0x00000004
\

$0000000f constant AXI_AXI_INI2_WRITE_QOS_AW_QOS                    \ Write channel QoS setting


\
\ @brief AXI interconnect - INI x issuing functionality modification register
\ Address offset: 0x43108
\ Reset value: 0x00000004
\

$00000001 constant AXI_AXI_INI2_FN_MOD_READ_ISS_OVERRIDE            \ Override ASIB read issuing capability
$00000002 constant AXI_AXI_INI2_FN_MOD_WRITE_ISS_OVERRIDE           \ Override ASIB write issuing capability


\
\ @brief AXI interconnect - INI x functionality modification 2 register
\ Address offset: 0x44024
\ Reset value: 0x00000004
\

$00000001 constant AXI_AXI_INI3_FN_MOD2_BYPASS_MERGE                \ Disables alteration of transactions by the up-sizer unless required by the protocol


\
\ @brief AXI interconnect - INI x AHB functionality modification register
\ Address offset: 0x44028
\ Reset value: 0x00000004
\

$00000001 constant AXI_AXI_INI3_FN_MOD_AHB_RD_INC_OVERRIDE          \ Converts all AHB-Lite write transactions to a series of single beat AXI
$00000002 constant AXI_AXI_INI3_FN_MOD_AHB_WR_INC_OVERRIDE          \ Converts all AHB-Lite read transactions to a series of single beat AXI


\
\ @brief AXI interconnect - INI x read QoS register
\ Address offset: 0x44100
\ Reset value: 0x00000004
\

$0000000f constant AXI_AXI_INI3_READ_QOS_AR_QOS                     \ Read channel QoS setting


\
\ @brief AXI interconnect - INI x write QoS register
\ Address offset: 0x44104
\ Reset value: 0x00000004
\

$0000000f constant AXI_AXI_INI3_WRITE_QOS_AW_QOS                    \ Write channel QoS setting


\
\ @brief AXI interconnect - INI x issuing functionality modification register
\ Address offset: 0x44108
\ Reset value: 0x00000004
\

$00000001 constant AXI_AXI_INI3_FN_MOD_READ_ISS_OVERRIDE            \ Override ASIB read issuing capability
$00000002 constant AXI_AXI_INI3_FN_MOD_WRITE_ISS_OVERRIDE           \ Override ASIB write issuing capability


\
\ @brief AXI interconnect - INI x read QoS register
\ Address offset: 0x45100
\ Reset value: 0x00000004
\

$0000000f constant AXI_AXI_INI4_READ_QOS_AR_QOS                     \ Read channel QoS setting


\
\ @brief AXI interconnect - INI x write QoS register
\ Address offset: 0x45104
\ Reset value: 0x00000004
\

$0000000f constant AXI_AXI_INI4_WRITE_QOS_AW_QOS                    \ Write channel QoS setting


\
\ @brief AXI interconnect - INI x issuing functionality modification register
\ Address offset: 0x45108
\ Reset value: 0x00000004
\

$00000001 constant AXI_AXI_INI4_FN_MOD_READ_ISS_OVERRIDE            \ Override ASIB read issuing capability
$00000002 constant AXI_AXI_INI4_FN_MOD_WRITE_ISS_OVERRIDE           \ Override ASIB write issuing capability


\
\ @brief AXI interconnect - INI x read QoS register
\ Address offset: 0x46100
\ Reset value: 0x00000004
\

$0000000f constant AXI_AXI_INI5_READ_QOS_AR_QOS                     \ Read channel QoS setting


\
\ @brief AXI interconnect - INI x write QoS register
\ Address offset: 0x46104
\ Reset value: 0x00000004
\

$0000000f constant AXI_AXI_INI5_WRITE_QOS_AW_QOS                    \ Write channel QoS setting


\
\ @brief AXI interconnect - INI x issuing functionality modification register
\ Address offset: 0x46108
\ Reset value: 0x00000004
\

$00000001 constant AXI_AXI_INI5_FN_MOD_READ_ISS_OVERRIDE            \ Override ASIB read issuing capability
$00000002 constant AXI_AXI_INI5_FN_MOD_WRITE_ISS_OVERRIDE           \ Override ASIB write issuing capability


\
\ @brief AXI interconnect - INI x read QoS register
\ Address offset: 0x47100
\ Reset value: 0x00000004
\

$0000000f constant AXI_AXI_INI6_READ_QOS_AR_QOS                     \ Read channel QoS setting


\
\ @brief AXI interconnect - INI x write QoS register
\ Address offset: 0x47104
\ Reset value: 0x00000004
\

$0000000f constant AXI_AXI_INI6_WRITE_QOS_AW_QOS                    \ Write channel QoS setting


\
\ @brief AXI interconnect - INI x issuing functionality modification register
\ Address offset: 0x47108
\ Reset value: 0x00000004
\

$00000001 constant AXI_AXI_INI6_FN_MOD_READ_ISS_OVERRIDE            \ Override ASIB read issuing capability
$00000002 constant AXI_AXI_INI6_FN_MOD_WRITE_ISS_OVERRIDE           \ Override ASIB write issuing capability


\
\ @brief AXI interconnect registers
\
$51001fd0 constant AXI_AXI_PERIPH_ID_4  \ offset: 0x1FD0 : AXI interconnect - peripheral ID4 register
$51001fe0 constant AXI_AXI_PERIPH_ID_0  \ offset: 0x1FE0 : AXI interconnect - peripheral ID0 register
$51001fe4 constant AXI_AXI_PERIPH_ID_1  \ offset: 0x1FE4 : AXI interconnect - peripheral ID1 register
$51001fe8 constant AXI_AXI_PERIPH_ID_2  \ offset: 0x1FE8 : AXI interconnect - peripheral ID2 register
$51001fec constant AXI_AXI_PERIPH_ID_3  \ offset: 0x1FEC : AXI interconnect - peripheral ID3 register
$51001ff0 constant AXI_AXI_COMP_ID_0  \ offset: 0x1FF0 : AXI interconnect - component ID0 register
$51001ff4 constant AXI_AXI_COMP_ID_1  \ offset: 0x1FF4 : AXI interconnect - component ID1 register
$51001ff8 constant AXI_AXI_COMP_ID_2  \ offset: 0x1FF8 : AXI interconnect - component ID2 register
$51001ffc constant AXI_AXI_COMP_ID_3  \ offset: 0x1FFC : AXI interconnect - component ID3 register
$51002008 constant AXI_AXI_TARG1_FN_MOD_ISS_BM  \ offset: 0x2008 : AXI interconnect - TARG x bus matrix issuing functionality register
$51002024 constant AXI_AXI_TARG1_FN_MOD2  \ offset: 0x2024 : AXI interconnect - TARG x bus matrix functionality 2 register
$5100202c constant AXI_AXI_TARG1_FN_MOD_LB  \ offset: 0x202C : AXI interconnect - TARG x long burst functionality modification
$51002108 constant AXI_AXI_TARG1_FN_MOD  \ offset: 0x2108 : AXI interconnect - TARG x long burst functionality modification
$51003008 constant AXI_AXI_TARG2_FN_MOD_ISS_BM  \ offset: 0x3008 : AXI interconnect - TARG x bus matrix issuing functionality register
$51003024 constant AXI_AXI_TARG2_FN_MOD2  \ offset: 0x3024 : AXI interconnect - TARG x bus matrix functionality 2 register
$5100302c constant AXI_AXI_TARG2_FN_MOD_LB  \ offset: 0x302C : AXI interconnect - TARG x long burst functionality modification
$51003108 constant AXI_AXI_TARG2_FN_MOD  \ offset: 0x3108 : AXI interconnect - TARG x long burst functionality modification
$51004008 constant AXI_AXI_TARG3_FN_MOD_ISS_BM  \ offset: 0x4008 : AXI interconnect - TARG x bus matrix issuing functionality register
$51005008 constant AXI_AXI_TARG4_FN_MOD_ISS_BM  \ offset: 0x5008 : AXI interconnect - TARG x bus matrix issuing functionality register
$51006008 constant AXI_AXI_TARG5_FN_MOD_ISS_BM  \ offset: 0x6008 : AXI interconnect - TARG x bus matrix issuing functionality register
$51007008 constant AXI_AXI_TARG6_FN_MOD_ISS_BM  \ offset: 0x7008 : AXI interconnect - TARG x bus matrix issuing functionality register
$5100800c constant AXI_AXI_TARG7_FN_MOD_ISS_BM  \ offset: 0x800C : AXI interconnect - TARG x bus matrix issuing functionality register
$51008024 constant AXI_AXI_TARG7_FN_MOD2  \ offset: 0x8024 : AXI interconnect - TARG x bus matrix functionality 2 register
$51008108 constant AXI_AXI_TARG7_FN_MOD  \ offset: 0x8108 : AXI interconnect - TARG x long burst functionality modification
$51042024 constant AXI_AXI_INI1_FN_MOD2  \ offset: 0x42024 : AXI interconnect - INI x functionality modification 2 register
$51042028 constant AXI_AXI_INI1_FN_MOD_AHB  \ offset: 0x42028 : AXI interconnect - INI x AHB functionality modification register
$51042100 constant AXI_AXI_INI1_READ_QOS  \ offset: 0x42100 : AXI interconnect - INI x read QoS register
$51042104 constant AXI_AXI_INI1_WRITE_QOS  \ offset: 0x42104 : AXI interconnect - INI x write QoS register
$51042108 constant AXI_AXI_INI1_FN_MOD  \ offset: 0x42108 : AXI interconnect - INI x issuing functionality modification register
$51043100 constant AXI_AXI_INI2_READ_QOS  \ offset: 0x43100 : AXI interconnect - INI x read QoS register
$51043104 constant AXI_AXI_INI2_WRITE_QOS  \ offset: 0x43104 : AXI interconnect - INI x write QoS register
$51043108 constant AXI_AXI_INI2_FN_MOD  \ offset: 0x43108 : AXI interconnect - INI x issuing functionality modification register
$51044024 constant AXI_AXI_INI3_FN_MOD2  \ offset: 0x44024 : AXI interconnect - INI x functionality modification 2 register
$51044028 constant AXI_AXI_INI3_FN_MOD_AHB  \ offset: 0x44028 : AXI interconnect - INI x AHB functionality modification register
$51044100 constant AXI_AXI_INI3_READ_QOS  \ offset: 0x44100 : AXI interconnect - INI x read QoS register
$51044104 constant AXI_AXI_INI3_WRITE_QOS  \ offset: 0x44104 : AXI interconnect - INI x write QoS register
$51044108 constant AXI_AXI_INI3_FN_MOD  \ offset: 0x44108 : AXI interconnect - INI x issuing functionality modification register
$51045100 constant AXI_AXI_INI4_READ_QOS  \ offset: 0x45100 : AXI interconnect - INI x read QoS register
$51045104 constant AXI_AXI_INI4_WRITE_QOS  \ offset: 0x45104 : AXI interconnect - INI x write QoS register
$51045108 constant AXI_AXI_INI4_FN_MOD  \ offset: 0x45108 : AXI interconnect - INI x issuing functionality modification register
$51046100 constant AXI_AXI_INI5_READ_QOS  \ offset: 0x46100 : AXI interconnect - INI x read QoS register
$51046104 constant AXI_AXI_INI5_WRITE_QOS  \ offset: 0x46104 : AXI interconnect - INI x write QoS register
$51046108 constant AXI_AXI_INI5_FN_MOD  \ offset: 0x46108 : AXI interconnect - INI x issuing functionality modification register
$51047100 constant AXI_AXI_INI6_READ_QOS  \ offset: 0x47100 : AXI interconnect - INI x read QoS register
$51047104 constant AXI_AXI_INI6_WRITE_QOS  \ offset: 0x47104 : AXI interconnect - INI x write QoS register
$51047108 constant AXI_AXI_INI6_FN_MOD  \ offset: 0x47108 : AXI interconnect - INI x issuing functionality modification register

