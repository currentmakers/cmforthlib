\
\ @file axi.fs
\ @brief AXI interconnect registers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] AXI_DEF

  [ifdef] AXI_AXI_PERIPH_ID_4_DEF
    \
    \ @brief AXI interconnect - peripheral ID4 register
    \ Address offset: 0x1FD0
    \ Reset value: 0x00000004
    \
    $00 constant AXI_JEP106CON                  \ [0x00 : 4] JEP106 continuation code
    $04 constant AXI_KCOUNT4                    \ [0x04 : 4] Register file size
  [then]


  [ifdef] AXI_AXI_PERIPH_ID_0_DEF
    \
    \ @brief AXI interconnect - peripheral ID0 register
    \ Address offset: 0x1FE0
    \ Reset value: 0x00000004
    \
    $00 constant AXI_PARTNUM                    \ [0x00 : 8] Peripheral part number bits 0 to 7
  [then]


  [ifdef] AXI_AXI_PERIPH_ID_1_DEF
    \
    \ @brief AXI interconnect - peripheral ID1 register
    \ Address offset: 0x1FE4
    \ Reset value: 0x00000004
    \
    $00 constant AXI_PARTNUM                    \ [0x00 : 4] Peripheral part number bits 8 to 11
    $04 constant AXI_JEP106I                    \ [0x04 : 4] JEP106 identity bits 0 to 3
  [then]


  [ifdef] AXI_AXI_PERIPH_ID_2_DEF
    \
    \ @brief AXI interconnect - peripheral ID2 register
    \ Address offset: 0x1FE8
    \ Reset value: 0x00000004
    \
    $00 constant AXI_JEP106ID                   \ [0x00 : 3] JEP106 Identity bits 4 to 6
    $03 constant AXI_JEDEC                      \ [0x03] JEP106 code flag
    $04 constant AXI_REVISION                   \ [0x04 : 4] Peripheral revision number
  [then]


  [ifdef] AXI_AXI_PERIPH_ID_3_DEF
    \
    \ @brief AXI interconnect - peripheral ID3 register
    \ Address offset: 0x1FEC
    \ Reset value: 0x00000004
    \
    $00 constant AXI_CUST_MOD_NUM               \ [0x00 : 4] Customer modification
    $04 constant AXI_REV_AND                    \ [0x04 : 4] Customer version
  [then]


  [ifdef] AXI_AXI_COMP_ID_0_DEF
    \
    \ @brief AXI interconnect - component ID0 register
    \ Address offset: 0x1FF0
    \ Reset value: 0x00000004
    \
    $00 constant AXI_PREAMBLE                   \ [0x00 : 8] Preamble bits 0 to 7
  [then]


  [ifdef] AXI_AXI_COMP_ID_1_DEF
    \
    \ @brief AXI interconnect - component ID1 register
    \ Address offset: 0x1FF4
    \ Reset value: 0x00000004
    \
    $00 constant AXI_PREAMBLE                   \ [0x00 : 4] Preamble bits 8 to 11
    $04 constant AXI_CLASS                      \ [0x04 : 4] Component class
  [then]


  [ifdef] AXI_AXI_COMP_ID_2_DEF
    \
    \ @brief AXI interconnect - component ID2 register
    \ Address offset: 0x1FF8
    \ Reset value: 0x00000004
    \
    $00 constant AXI_PREAMBLE                   \ [0x00 : 8] Preamble bits 12 to 19
  [then]


  [ifdef] AXI_AXI_COMP_ID_3_DEF
    \
    \ @brief AXI interconnect - component ID3 register
    \ Address offset: 0x1FFC
    \ Reset value: 0x00000004
    \
    $00 constant AXI_PREAMBLE                   \ [0x00 : 8] Preamble bits 20 to 27
  [then]


  [ifdef] AXI_AXI_TARG1_FN_MOD_ISS_BM_DEF
    \
    \ @brief AXI interconnect - TARG x bus matrix issuing functionality register
    \ Address offset: 0x2008
    \ Reset value: 0x00000004
    \
    $00 constant AXI_READ_ISS_OVERRIDE          \ [0x00] READ_ISS_OVERRIDE
    $01 constant AXI_WRITE_ISS_OVERRIDE         \ [0x01] Switch matrix write issuing override for target
  [then]


  [ifdef] AXI_AXI_TARG1_FN_MOD2_DEF
    \
    \ @brief AXI interconnect - TARG x bus matrix functionality 2 register
    \ Address offset: 0x2024
    \ Reset value: 0x00000004
    \
    $00 constant AXI_BYPASS_MERGE               \ [0x00] Disable packing of beats to match the output data width
  [then]


  [ifdef] AXI_AXI_TARG1_FN_MOD_LB_DEF
    \
    \ @brief AXI interconnect - TARG x long burst functionality modification
    \ Address offset: 0x202C
    \ Reset value: 0x00000004
    \
    $00 constant AXI_FN_MOD_LB                  \ [0x00] Controls burst breaking of long bursts
  [then]


  [ifdef] AXI_AXI_TARG1_FN_MOD_DEF
    \
    \ @brief AXI interconnect - TARG x long burst functionality modification
    \ Address offset: 0x2108
    \ Reset value: 0x00000004
    \
    $00 constant AXI_READ_ISS_OVERRIDE          \ [0x00] Override AMIB read issuing capability
    $01 constant AXI_WRITE_ISS_OVERRIDE         \ [0x01] Override AMIB write issuing capability
  [then]


  [ifdef] AXI_AXI_TARG2_FN_MOD_ISS_BM_DEF
    \
    \ @brief AXI interconnect - TARG x bus matrix issuing functionality register
    \ Address offset: 0x3008
    \ Reset value: 0x00000004
    \
    $00 constant AXI_READ_ISS_OVERRIDE          \ [0x00] READ_ISS_OVERRIDE
    $01 constant AXI_WRITE_ISS_OVERRIDE         \ [0x01] Switch matrix write issuing override for target
  [then]


  [ifdef] AXI_AXI_TARG2_FN_MOD2_DEF
    \
    \ @brief AXI interconnect - TARG x bus matrix functionality 2 register
    \ Address offset: 0x3024
    \ Reset value: 0x00000004
    \
    $00 constant AXI_BYPASS_MERGE               \ [0x00] Disable packing of beats to match the output data width
  [then]


  [ifdef] AXI_AXI_TARG2_FN_MOD_LB_DEF
    \
    \ @brief AXI interconnect - TARG x long burst functionality modification
    \ Address offset: 0x302C
    \ Reset value: 0x00000004
    \
    $00 constant AXI_FN_MOD_LB                  \ [0x00] Controls burst breaking of long bursts
  [then]


  [ifdef] AXI_AXI_TARG2_FN_MOD_DEF
    \
    \ @brief AXI interconnect - TARG x long burst functionality modification
    \ Address offset: 0x3108
    \ Reset value: 0x00000004
    \
    $00 constant AXI_READ_ISS_OVERRIDE          \ [0x00] Override AMIB read issuing capability
    $01 constant AXI_WRITE_ISS_OVERRIDE         \ [0x01] Override AMIB write issuing capability
  [then]


  [ifdef] AXI_AXI_TARG3_FN_MOD_ISS_BM_DEF
    \
    \ @brief AXI interconnect - TARG x bus matrix issuing functionality register
    \ Address offset: 0x4008
    \ Reset value: 0x00000004
    \
    $00 constant AXI_READ_ISS_OVERRIDE          \ [0x00] READ_ISS_OVERRIDE
    $01 constant AXI_WRITE_ISS_OVERRIDE         \ [0x01] Switch matrix write issuing override for target
  [then]


  [ifdef] AXI_AXI_TARG4_FN_MOD_ISS_BM_DEF
    \
    \ @brief AXI interconnect - TARG x bus matrix issuing functionality register
    \ Address offset: 0x5008
    \ Reset value: 0x00000004
    \
    $00 constant AXI_READ_ISS_OVERRIDE          \ [0x00] READ_ISS_OVERRIDE
    $01 constant AXI_WRITE_ISS_OVERRIDE         \ [0x01] Switch matrix write issuing override for target
  [then]


  [ifdef] AXI_AXI_TARG5_FN_MOD_ISS_BM_DEF
    \
    \ @brief AXI interconnect - TARG x bus matrix issuing functionality register
    \ Address offset: 0x6008
    \ Reset value: 0x00000004
    \
    $00 constant AXI_READ_ISS_OVERRIDE          \ [0x00] READ_ISS_OVERRIDE
    $01 constant AXI_WRITE_ISS_OVERRIDE         \ [0x01] Switch matrix write issuing override for target
  [then]


  [ifdef] AXI_AXI_TARG6_FN_MOD_ISS_BM_DEF
    \
    \ @brief AXI interconnect - TARG x bus matrix issuing functionality register
    \ Address offset: 0x7008
    \ Reset value: 0x00000004
    \
    $00 constant AXI_READ_ISS_OVERRIDE          \ [0x00] READ_ISS_OVERRIDE
    $01 constant AXI_WRITE_ISS_OVERRIDE         \ [0x01] Switch matrix write issuing override for target
  [then]


  [ifdef] AXI_AXI_TARG7_FN_MOD_ISS_BM_DEF
    \
    \ @brief AXI interconnect - TARG x bus matrix issuing functionality register
    \ Address offset: 0x800C
    \ Reset value: 0x00000004
    \
    $00 constant AXI_READ_ISS_OVERRIDE          \ [0x00] READ_ISS_OVERRIDE
    $01 constant AXI_WRITE_ISS_OVERRIDE         \ [0x01] Switch matrix write issuing override for target
  [then]


  [ifdef] AXI_AXI_TARG7_FN_MOD2_DEF
    \
    \ @brief AXI interconnect - TARG x bus matrix functionality 2 register
    \ Address offset: 0x8024
    \ Reset value: 0x00000004
    \
    $00 constant AXI_BYPASS_MERGE               \ [0x00] Disable packing of beats to match the output data width
  [then]


  [ifdef] AXI_AXI_TARG7_FN_MOD_DEF
    \
    \ @brief AXI interconnect - TARG x long burst functionality modification
    \ Address offset: 0x8108
    \ Reset value: 0x00000004
    \
    $00 constant AXI_READ_ISS_OVERRIDE          \ [0x00] Override AMIB read issuing capability
    $01 constant AXI_WRITE_ISS_OVERRIDE         \ [0x01] Override AMIB write issuing capability
  [then]


  [ifdef] AXI_AXI_INI1_FN_MOD2_DEF
    \
    \ @brief AXI interconnect - INI x functionality modification 2 register
    \ Address offset: 0x42024
    \ Reset value: 0x00000004
    \
    $00 constant AXI_BYPASS_MERGE               \ [0x00] Disables alteration of transactions by the up-sizer unless required by the protocol
  [then]


  [ifdef] AXI_AXI_INI1_FN_MOD_AHB_DEF
    \
    \ @brief AXI interconnect - INI x AHB functionality modification register
    \ Address offset: 0x42028
    \ Reset value: 0x00000004
    \
    $00 constant AXI_RD_INC_OVERRIDE            \ [0x00] Converts all AHB-Lite write transactions to a series of single beat AXI
    $01 constant AXI_WR_INC_OVERRIDE            \ [0x01] Converts all AHB-Lite read transactions to a series of single beat AXI
  [then]


  [ifdef] AXI_AXI_INI1_READ_QOS_DEF
    \
    \ @brief AXI interconnect - INI x read QoS register
    \ Address offset: 0x42100
    \ Reset value: 0x00000004
    \
    $00 constant AXI_AR_QOS                     \ [0x00 : 4] Read channel QoS setting
  [then]


  [ifdef] AXI_AXI_INI1_WRITE_QOS_DEF
    \
    \ @brief AXI interconnect - INI x write QoS register
    \ Address offset: 0x42104
    \ Reset value: 0x00000004
    \
    $00 constant AXI_AW_QOS                     \ [0x00 : 4] Write channel QoS setting
  [then]


  [ifdef] AXI_AXI_INI1_FN_MOD_DEF
    \
    \ @brief AXI interconnect - INI x issuing functionality modification register
    \ Address offset: 0x42108
    \ Reset value: 0x00000004
    \
    $00 constant AXI_READ_ISS_OVERRIDE          \ [0x00] Override ASIB read issuing capability
    $01 constant AXI_WRITE_ISS_OVERRIDE         \ [0x01] Override ASIB write issuing capability
  [then]


  [ifdef] AXI_AXI_INI2_READ_QOS_DEF
    \
    \ @brief AXI interconnect - INI x read QoS register
    \ Address offset: 0x43100
    \ Reset value: 0x00000004
    \
    $00 constant AXI_AR_QOS                     \ [0x00 : 4] Read channel QoS setting
  [then]


  [ifdef] AXI_AXI_INI2_WRITE_QOS_DEF
    \
    \ @brief AXI interconnect - INI x write QoS register
    \ Address offset: 0x43104
    \ Reset value: 0x00000004
    \
    $00 constant AXI_AW_QOS                     \ [0x00 : 4] Write channel QoS setting
  [then]


  [ifdef] AXI_AXI_INI2_FN_MOD_DEF
    \
    \ @brief AXI interconnect - INI x issuing functionality modification register
    \ Address offset: 0x43108
    \ Reset value: 0x00000004
    \
    $00 constant AXI_READ_ISS_OVERRIDE          \ [0x00] Override ASIB read issuing capability
    $01 constant AXI_WRITE_ISS_OVERRIDE         \ [0x01] Override ASIB write issuing capability
  [then]


  [ifdef] AXI_AXI_INI3_FN_MOD2_DEF
    \
    \ @brief AXI interconnect - INI x functionality modification 2 register
    \ Address offset: 0x44024
    \ Reset value: 0x00000004
    \
    $00 constant AXI_BYPASS_MERGE               \ [0x00] Disables alteration of transactions by the up-sizer unless required by the protocol
  [then]


  [ifdef] AXI_AXI_INI3_FN_MOD_AHB_DEF
    \
    \ @brief AXI interconnect - INI x AHB functionality modification register
    \ Address offset: 0x44028
    \ Reset value: 0x00000004
    \
    $00 constant AXI_RD_INC_OVERRIDE            \ [0x00] Converts all AHB-Lite write transactions to a series of single beat AXI
    $01 constant AXI_WR_INC_OVERRIDE            \ [0x01] Converts all AHB-Lite read transactions to a series of single beat AXI
  [then]


  [ifdef] AXI_AXI_INI3_READ_QOS_DEF
    \
    \ @brief AXI interconnect - INI x read QoS register
    \ Address offset: 0x44100
    \ Reset value: 0x00000004
    \
    $00 constant AXI_AR_QOS                     \ [0x00 : 4] Read channel QoS setting
  [then]


  [ifdef] AXI_AXI_INI3_WRITE_QOS_DEF
    \
    \ @brief AXI interconnect - INI x write QoS register
    \ Address offset: 0x44104
    \ Reset value: 0x00000004
    \
    $00 constant AXI_AW_QOS                     \ [0x00 : 4] Write channel QoS setting
  [then]


  [ifdef] AXI_AXI_INI3_FN_MOD_DEF
    \
    \ @brief AXI interconnect - INI x issuing functionality modification register
    \ Address offset: 0x44108
    \ Reset value: 0x00000004
    \
    $00 constant AXI_READ_ISS_OVERRIDE          \ [0x00] Override ASIB read issuing capability
    $01 constant AXI_WRITE_ISS_OVERRIDE         \ [0x01] Override ASIB write issuing capability
  [then]


  [ifdef] AXI_AXI_INI4_READ_QOS_DEF
    \
    \ @brief AXI interconnect - INI x read QoS register
    \ Address offset: 0x45100
    \ Reset value: 0x00000004
    \
    $00 constant AXI_AR_QOS                     \ [0x00 : 4] Read channel QoS setting
  [then]


  [ifdef] AXI_AXI_INI4_WRITE_QOS_DEF
    \
    \ @brief AXI interconnect - INI x write QoS register
    \ Address offset: 0x45104
    \ Reset value: 0x00000004
    \
    $00 constant AXI_AW_QOS                     \ [0x00 : 4] Write channel QoS setting
  [then]


  [ifdef] AXI_AXI_INI4_FN_MOD_DEF
    \
    \ @brief AXI interconnect - INI x issuing functionality modification register
    \ Address offset: 0x45108
    \ Reset value: 0x00000004
    \
    $00 constant AXI_READ_ISS_OVERRIDE          \ [0x00] Override ASIB read issuing capability
    $01 constant AXI_WRITE_ISS_OVERRIDE         \ [0x01] Override ASIB write issuing capability
  [then]


  [ifdef] AXI_AXI_INI5_READ_QOS_DEF
    \
    \ @brief AXI interconnect - INI x read QoS register
    \ Address offset: 0x46100
    \ Reset value: 0x00000004
    \
    $00 constant AXI_AR_QOS                     \ [0x00 : 4] Read channel QoS setting
  [then]


  [ifdef] AXI_AXI_INI5_WRITE_QOS_DEF
    \
    \ @brief AXI interconnect - INI x write QoS register
    \ Address offset: 0x46104
    \ Reset value: 0x00000004
    \
    $00 constant AXI_AW_QOS                     \ [0x00 : 4] Write channel QoS setting
  [then]


  [ifdef] AXI_AXI_INI5_FN_MOD_DEF
    \
    \ @brief AXI interconnect - INI x issuing functionality modification register
    \ Address offset: 0x46108
    \ Reset value: 0x00000004
    \
    $00 constant AXI_READ_ISS_OVERRIDE          \ [0x00] Override ASIB read issuing capability
    $01 constant AXI_WRITE_ISS_OVERRIDE         \ [0x01] Override ASIB write issuing capability
  [then]


  [ifdef] AXI_AXI_INI6_READ_QOS_DEF
    \
    \ @brief AXI interconnect - INI x read QoS register
    \ Address offset: 0x47100
    \ Reset value: 0x00000004
    \
    $00 constant AXI_AR_QOS                     \ [0x00 : 4] Read channel QoS setting
  [then]


  [ifdef] AXI_AXI_INI6_WRITE_QOS_DEF
    \
    \ @brief AXI interconnect - INI x write QoS register
    \ Address offset: 0x47104
    \ Reset value: 0x00000004
    \
    $00 constant AXI_AW_QOS                     \ [0x00 : 4] Write channel QoS setting
  [then]


  [ifdef] AXI_AXI_INI6_FN_MOD_DEF
    \
    \ @brief AXI interconnect - INI x issuing functionality modification register
    \ Address offset: 0x47108
    \ Reset value: 0x00000004
    \
    $00 constant AXI_READ_ISS_OVERRIDE          \ [0x00] Override ASIB read issuing capability
    $01 constant AXI_WRITE_ISS_OVERRIDE         \ [0x01] Override ASIB write issuing capability
  [then]

  \
  \ @brief AXI interconnect registers
  \
  $1FD0 constant AXI_AXI_PERIPH_ID_4    \ AXI interconnect - peripheral ID4 register
  $1FE0 constant AXI_AXI_PERIPH_ID_0    \ AXI interconnect - peripheral ID0 register
  $1FE4 constant AXI_AXI_PERIPH_ID_1    \ AXI interconnect - peripheral ID1 register
  $1FE8 constant AXI_AXI_PERIPH_ID_2    \ AXI interconnect - peripheral ID2 register
  $1FEC constant AXI_AXI_PERIPH_ID_3    \ AXI interconnect - peripheral ID3 register
  $1FF0 constant AXI_AXI_COMP_ID_0      \ AXI interconnect - component ID0 register
  $1FF4 constant AXI_AXI_COMP_ID_1      \ AXI interconnect - component ID1 register
  $1FF8 constant AXI_AXI_COMP_ID_2      \ AXI interconnect - component ID2 register
  $1FFC constant AXI_AXI_COMP_ID_3      \ AXI interconnect - component ID3 register
  $2008 constant AXI_AXI_TARG1_FN_MOD_ISS_BM    \ AXI interconnect - TARG x bus matrix issuing functionality register
  $2024 constant AXI_AXI_TARG1_FN_MOD2  \ AXI interconnect - TARG x bus matrix functionality 2 register
  $202C constant AXI_AXI_TARG1_FN_MOD_LB    \ AXI interconnect - TARG x long burst functionality modification
  $2108 constant AXI_AXI_TARG1_FN_MOD   \ AXI interconnect - TARG x long burst functionality modification
  $3008 constant AXI_AXI_TARG2_FN_MOD_ISS_BM    \ AXI interconnect - TARG x bus matrix issuing functionality register
  $3024 constant AXI_AXI_TARG2_FN_MOD2  \ AXI interconnect - TARG x bus matrix functionality 2 register
  $302C constant AXI_AXI_TARG2_FN_MOD_LB    \ AXI interconnect - TARG x long burst functionality modification
  $3108 constant AXI_AXI_TARG2_FN_MOD   \ AXI interconnect - TARG x long burst functionality modification
  $4008 constant AXI_AXI_TARG3_FN_MOD_ISS_BM    \ AXI interconnect - TARG x bus matrix issuing functionality register
  $5008 constant AXI_AXI_TARG4_FN_MOD_ISS_BM    \ AXI interconnect - TARG x bus matrix issuing functionality register
  $6008 constant AXI_AXI_TARG5_FN_MOD_ISS_BM    \ AXI interconnect - TARG x bus matrix issuing functionality register
  $7008 constant AXI_AXI_TARG6_FN_MOD_ISS_BM    \ AXI interconnect - TARG x bus matrix issuing functionality register
  $800C constant AXI_AXI_TARG7_FN_MOD_ISS_BM    \ AXI interconnect - TARG x bus matrix issuing functionality register
  $8024 constant AXI_AXI_TARG7_FN_MOD2  \ AXI interconnect - TARG x bus matrix functionality 2 register
  $8108 constant AXI_AXI_TARG7_FN_MOD   \ AXI interconnect - TARG x long burst functionality modification
  $42024 constant AXI_AXI_INI1_FN_MOD2  \ AXI interconnect - INI x functionality modification 2 register
  $42028 constant AXI_AXI_INI1_FN_MOD_AHB    \ AXI interconnect - INI x AHB functionality modification register
  $42100 constant AXI_AXI_INI1_READ_QOS \ AXI interconnect - INI x read QoS register
  $42104 constant AXI_AXI_INI1_WRITE_QOS    \ AXI interconnect - INI x write QoS register
  $42108 constant AXI_AXI_INI1_FN_MOD   \ AXI interconnect - INI x issuing functionality modification register
  $43100 constant AXI_AXI_INI2_READ_QOS \ AXI interconnect - INI x read QoS register
  $43104 constant AXI_AXI_INI2_WRITE_QOS    \ AXI interconnect - INI x write QoS register
  $43108 constant AXI_AXI_INI2_FN_MOD   \ AXI interconnect - INI x issuing functionality modification register
  $44024 constant AXI_AXI_INI3_FN_MOD2  \ AXI interconnect - INI x functionality modification 2 register
  $44028 constant AXI_AXI_INI3_FN_MOD_AHB    \ AXI interconnect - INI x AHB functionality modification register
  $44100 constant AXI_AXI_INI3_READ_QOS \ AXI interconnect - INI x read QoS register
  $44104 constant AXI_AXI_INI3_WRITE_QOS    \ AXI interconnect - INI x write QoS register
  $44108 constant AXI_AXI_INI3_FN_MOD   \ AXI interconnect - INI x issuing functionality modification register
  $45100 constant AXI_AXI_INI4_READ_QOS \ AXI interconnect - INI x read QoS register
  $45104 constant AXI_AXI_INI4_WRITE_QOS    \ AXI interconnect - INI x write QoS register
  $45108 constant AXI_AXI_INI4_FN_MOD   \ AXI interconnect - INI x issuing functionality modification register
  $46100 constant AXI_AXI_INI5_READ_QOS \ AXI interconnect - INI x read QoS register
  $46104 constant AXI_AXI_INI5_WRITE_QOS    \ AXI interconnect - INI x write QoS register
  $46108 constant AXI_AXI_INI5_FN_MOD   \ AXI interconnect - INI x issuing functionality modification register
  $47100 constant AXI_AXI_INI6_READ_QOS \ AXI interconnect - INI x read QoS register
  $47104 constant AXI_AXI_INI6_WRITE_QOS    \ AXI interconnect - INI x write QoS register
  $47108 constant AXI_AXI_INI6_FN_MOD   \ AXI interconnect - INI x issuing functionality modification register

: AXI_DEF ; [then]
