\
\ @file aximc.fs
\ @brief AXIMC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] AXIMC_DEF

  [ifdef] AXIMC_AXIMC_PERIPH_ID_4_DEF
    \
    \ @brief AXIMC peripheral ID4 register
    \ Address offset: 0x1FD0
    \ Reset value: 0x00000004
    \
    $00 constant AXIMC_JEP106CON                \ [0x00 : 4] JEP106 continuation code
    $04 constant AXIMC_K4COUNT                  \ [0x04 : 4] register file size
  [then]


  [ifdef] AXIMC_AXIMC_PERIPH_ID_5_DEF
    \
    \ @brief AXIMC peripheral ID5 register
    \ Address offset: 0x1FD4
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_PERIPH_ID_5              \ [0x00 : 8] reserved, not used.
  [then]


  [ifdef] AXIMC_AXIMC_PERIPH_ID_6_DEF
    \
    \ @brief AXIMC peripheral ID6 register
    \ Address offset: 0x1FD8
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_PERIPH_ID_6              \ [0x00 : 8] reserved, not used.
  [then]


  [ifdef] AXIMC_AXIMC_PERIPH_ID_7_DEF
    \
    \ @brief AXIMC peripheral ID7 register
    \ Address offset: 0x1FDC
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_PERIPH_ID_7              \ [0x00 : 8] reserved, not used.
  [then]


  [ifdef] AXIMC_AXIMC_PERIPH_ID_0_DEF
    \
    \ @brief AXIMC peripheral ID0 register
    \ Address offset: 0x1FE0
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_PERIPH_ID_0              \ [0x00 : 8] part number [7:0]
  [then]


  [ifdef] AXIMC_AXIMC_PERIPH_ID_1_DEF
    \
    \ @brief AXIMC peripheral ID1 register
    \ Address offset: 0x1FE4
    \ Reset value: 0x000000B4
    \
    $00 constant AXIMC_PERIPH_ID_1              \ [0x00 : 8] JEP106 identity [3:0], part number [11:8]
  [then]


  [ifdef] AXIMC_AXIMC_PERIPH_ID_2_DEF
    \
    \ @brief AXIMC peripheral ID2 register
    \ Address offset: 0x1FE8
    \ Reset value: 0x0000003B
    \
    $00 constant AXIMC_PERIPH_ID_2              \ [0x00 : 8] part revision, JEP106 code flag, JEP106 identity [6:4]
  [then]


  [ifdef] AXIMC_AXIMC_PERIPH_ID_3_DEF
    \
    \ @brief AXIMC peripheral ID3 register
    \ Address offset: 0x1FEC
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_CUST_MOD_NUM             \ [0x00 : 4] customer modification
    $04 constant AXIMC_REV_AND                  \ [0x04 : 4] customer version
  [then]


  [ifdef] AXIMC_AXIMC_COMP_ID_0_DEF
    \
    \ @brief AXIMC component ID0 register
    \ Address offset: 0x1FF0
    \ Reset value: 0x0000000D
    \
    $00 constant AXIMC_PREAMBLE                 \ [0x00 : 8] preamble bits [7:0]
  [then]


  [ifdef] AXIMC_AXIMC_COMP_ID_1_DEF
    \
    \ @brief AXIMC component ID1 register
    \ Address offset: 0x1FF4
    \ Reset value: 0x000000F0
    \
    $00 constant AXIMC_PREAMBLE                 \ [0x00 : 4] preamble bits [11:8]
    $04 constant AXIMC_CLASS                    \ [0x04 : 4] Component class
  [then]


  [ifdef] AXIMC_AXIMC_COMP_ID_2_DEF
    \
    \ @brief AXIMC component ID2 register
    \ Address offset: 0x1FF8
    \ Reset value: 0x00000005
    \
    $00 constant AXIMC_PREAMBLE                 \ [0x00 : 8] preamble bits [19:12]
  [then]


  [ifdef] AXIMC_AXIMC_COMP_ID_3_DEF
    \
    \ @brief AXIMC component ID3 register
    \ Address offset: 0x1FFC
    \ Reset value: 0x000000B1
    \
    $00 constant AXIMC_PREAMBLE                 \ [0x00 : 8] preamble bits [27:20]
  [then]


  [ifdef] AXIMC_AXIMC_M0_FN_MOD2_DEF
    \
    \ @brief AXIMC master 0 packing functionality register
    \ Address offset: 0x42024
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_BYPASS_MERGE             \ [0x00] Disable packing of beats to match the output data width Unaligned transactions are not realigned to the input data word boundary.
  [then]


  [ifdef] AXIMC_AXIMC_M0_FN_MOD_AHB_DEF
    \
    \ @brief AXIMC master 0 AHB conversion override functionality register
    \ Address offset: 0x42028
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_RD_INC_OVERRIDE          \ [0x00] Converts all AHB-Lite write transactions to a series of single beat AXI transactions, and each AHB-Lite write beat is acknowledged with the AXI buffered write response.
    $01 constant AXIMC_WR_INC_OVERRIDE          \ [0x01] Converts all AHB-Lite read transactions to a series of single beat AXI transactions
  [then]


  [ifdef] AXIMC_AXIMC_M0_READ_QOS_DEF
    \
    \ @brief AXIMC master 0 read priority register
    \ Address offset: 0x42100
    \ Reset value: 0x00000006
    \
    $00 constant AXIMC_AR_QOS                   \ [0x00 : 4] read channel QoS setting
  [then]


  [ifdef] AXIMC_AXIMC_M0_WRITE_QOS_DEF
    \
    \ @brief AXIMC master 0 write priority register
    \ Address offset: 0x42104
    \ Reset value: 0x00000006
    \
    $00 constant AXIMC_AW_QOS                   \ [0x00 : 4] write channel QoS setting
  [then]


  [ifdef] AXIMC_AXIMC_M0_FN_MOD_DEF
    \
    \ @brief AXIMC master 0 issuing capability override functionality register
    \ Address offset: 0x42108
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_READ_ISS_OVERRIDE        \ [0x00] override AMIB read issuing capability
    $01 constant AXIMC_WRITE_ISS_OVERRIDE       \ [0x01] override AMIB write issuing capability
  [then]


  [ifdef] AXIMC_AXIMC_M1_FN_MOD2_DEF
    \
    \ @brief AXIMC master 1 packing functionality register
    \ Address offset: 0x43024
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_BYPASS_MERGE             \ [0x00] Disable packing of beats to match the output data width Unaligned transactions are not realigned to the input data word boundary.
  [then]


  [ifdef] AXIMC_AXIMC_M1_FN_MOD_AHB_DEF
    \
    \ @brief AXIMC master 1 AHB conversion override functionality register
    \ Address offset: 0x43028
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_RD_INC_OVERRIDE          \ [0x00] Converts all AHB-Lite write transactions to a series of single beat AXI transactions, and each AHB-Lite write beat is acknowledged with the AXI buffered write response.
    $01 constant AXIMC_WR_INC_OVERRIDE          \ [0x01] Converts all AHB-Lite read transactions to a series of single beat AXI transactions
  [then]


  [ifdef] AXIMC_AXIMC_M1_READ_QOS_DEF
    \
    \ @brief AXIMC master 1 read priority register
    \ Address offset: 0x43100
    \ Reset value: 0x00000006
    \
    $00 constant AXIMC_AR_QOS                   \ [0x00 : 4] read channel QoS setting
  [then]


  [ifdef] AXIMC_AXIMC_M1_WRITE_QOS_DEF
    \
    \ @brief AXIMC master 1 write priority register
    \ Address offset: 0x43104
    \ Reset value: 0x00000006
    \
    $00 constant AXIMC_AW_QOS                   \ [0x00 : 4] write channel QoS setting
  [then]


  [ifdef] AXIMC_AXIMC_M1_FN_MOD_DEF
    \
    \ @brief AXIMC master 1 issuing capability override functionality register
    \ Address offset: 0x43108
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_READ_ISS_OVERRIDE        \ [0x00] override AMIB read issuing capability
    $01 constant AXIMC_WRITE_ISS_OVERRIDE       \ [0x01] override AMIB write issuing capability
  [then]


  [ifdef] AXIMC_AXIMC_M2_FN_MOD2_DEF
    \
    \ @brief AXIMC master 2 packing functionality register
    \ Address offset: 0x44024
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_BYPASS_MERGE             \ [0x00] Disable packing of beats to match the output data width Unaligned transactions are not realigned to the input data word boundary.
  [then]


  [ifdef] AXIMC_AXIMC_M2_FN_MOD_AHB_DEF
    \
    \ @brief AXIMC master 2 AHB conversion override functionality register
    \ Address offset: 0x44028
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_RD_INC_OVERRIDE          \ [0x00] Converts all AHB-Lite write transactions to a series of single beat AXI transactions, and each AHB-Lite write beat is acknowledged with the AXI buffered write response.
    $01 constant AXIMC_WR_INC_OVERRIDE          \ [0x01] Converts all AHB-Lite read transactions to a series of single beat AXI transactions
  [then]


  [ifdef] AXIMC_AXIMC_M2_READ_QOS_DEF
    \
    \ @brief AXIMC master 2 read priority register
    \ Address offset: 0x44100
    \ Reset value: 0x00000006
    \
    $00 constant AXIMC_AR_QOS                   \ [0x00 : 4] read channel QoS setting
  [then]


  [ifdef] AXIMC_AXIMC_M2_WRITE_QOS_DEF
    \
    \ @brief AXIMC master 2 write priority register
    \ Address offset: 0x44104
    \ Reset value: 0x00000006
    \
    $00 constant AXIMC_AW_QOS                   \ [0x00 : 4] write channel QoS setting
  [then]


  [ifdef] AXIMC_AXIMC_M2_FN_MOD_DEF
    \
    \ @brief AXIMC master 2 issuing capability override functionality register
    \ Address offset: 0x44108
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_READ_ISS_OVERRIDE        \ [0x00] override AMIB read issuing capability
    $01 constant AXIMC_WRITE_ISS_OVERRIDE       \ [0x01] override AMIB write issuing capability
  [then]


  [ifdef] AXIMC_AXIMC_M3_READ_QOS_DEF
    \
    \ @brief AXIMC master 3 read priority register
    \ Address offset: 0x45100
    \ Reset value: 0x00000007
    \
    $00 constant AXIMC_AR_QOS                   \ [0x00 : 4] read channel QoS setting
  [then]


  [ifdef] AXIMC_AXIMC_M3_WRITE_QOS_DEF
    \
    \ @brief AXIMC master 3 write priority register
    \ Address offset: 0x45104
    \ Reset value: 0x00000007
    \
    $00 constant AXIMC_AW_QOS                   \ [0x00 : 4] write channel QoS setting
  [then]


  [ifdef] AXIMC_AXIMC_M3_FN_MOD_DEF
    \
    \ @brief AXIMC master 3 packing functionality register
    \ Address offset: 0x45108
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_READ_ISS_OVERRIDE        \ [0x00] override AMIB read issuing capability
    $01 constant AXIMC_WRITE_ISS_OVERRIDE       \ [0x01] override AMIB write issuing capability
  [then]


  [ifdef] AXIMC_AXIMC_M4_FN_MOD_LB_DEF
    \
    \ @brief AXIMC long burst capability inhibition register
    \ Address offset: 0x4602C
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_FN_MOD_LB                \ [0x00] controls burst breaking of long bursts
  [then]


  [ifdef] AXIMC_AXIMC_M4_READ_QOS_DEF
    \
    \ @brief AXIMC master 4 read priority register
    \ Address offset: 0x46100
    \ Reset value: 0x00000007
    \
    $00 constant AXIMC_AR_QOS                   \ [0x00 : 4] read channel QoS setting
  [then]


  [ifdef] AXIMC_AXIMC_M4_WRITE_QOS_DEF
    \
    \ @brief AXIMC master 4 write priority register
    \ Address offset: 0x46104
    \ Reset value: 0x00000007
    \
    $00 constant AXIMC_AW_QOS                   \ [0x00 : 4] write channel QoS setting
  [then]


  [ifdef] AXIMC_AXIMC_M4_FN_MOD_DEF
    \
    \ @brief AXIMC master 4 packing functionality register
    \ Address offset: 0x46108
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_READ_ISS_OVERRIDE        \ [0x00] override AMIB read issuing capability
    $01 constant AXIMC_WRITE_ISS_OVERRIDE       \ [0x01] override AMIB write issuing capability
  [then]


  [ifdef] AXIMC_AXIMC_M5_FN_MOD2_DEF
    \
    \ @brief AXIMC master 5 packing functionality register
    \ Address offset: 0x47024
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_BYPASS_MERGE             \ [0x00] Disable packing of beats to match the output data width Unaligned transactions are not realigned to the input data word boundary.
  [then]


  [ifdef] AXIMC_AXIMC_M5_FN_MOD_AHB_DEF
    \
    \ @brief AXIMC master 5 AHB conversion override functionality register
    \ Address offset: 0x47028
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_RD_INC_OVERRIDE          \ [0x00] converts all AHB-Lite write transactions to a series of single beat AXI transactions, and each AHB-Lite write beat is acknowledged with the AXI buffered write response.
    $01 constant AXIMC_WR_INC_OVERRIDE          \ [0x01] converts all AHB-Lite read transactions to a series of single beat AXI transactions
  [then]


  [ifdef] AXIMC_AXIMC_M5_READ_QOS_DEF
    \
    \ @brief AXIMC master 5 read priority register
    \ Address offset: 0x47100
    \ Reset value: 0x00000004
    \
    $00 constant AXIMC_AR_QOS                   \ [0x00 : 4] read channel QoS setting
  [then]


  [ifdef] AXIMC_AXIMC_M5_WRITE_QOS_DEF
    \
    \ @brief AXIMC master 5 write priority register
    \ Address offset: 0x47104
    \ Reset value: 0x00000004
    \
    $00 constant AXIMC_AW_QOS                   \ [0x00 : 4] write channel QoS setting
  [then]


  [ifdef] AXIMC_AXIMC_M5_FN_MOD_DEF
    \
    \ @brief AXIMC master 5 issuing capability override functionality register
    \ Address offset: 0x47108
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_READ_ISS_OVERRIDE        \ [0x00] override AMIB read issuing capability
    $01 constant AXIMC_WRITE_ISS_OVERRIDE       \ [0x01] override AMIB write issuing capability
  [then]


  [ifdef] AXIMC_AXIMC_M6_FN_MOD2_DEF
    \
    \ @brief AXIMC master 6 packing functionality register
    \ Address offset: 0x48024
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_BYPASS_MERGE             \ [0x00] Disable packing of beats to match the output data width Unaligned transactions are not realigned to the input data word boundary.
  [then]


  [ifdef] AXIMC_AXIMC_M6_FN_MOD_AHB_DEF
    \
    \ @brief AXIMC master 6 AHB conversion override functionality register
    \ Address offset: 0x48028
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_RD_INC_OVERRIDE          \ [0x00] converts all AHB-Lite write transactions to a series of single beat AXI transactions, and each AHB-Lite write beat is acknowledged with the AXI buffered write response.
    $01 constant AXIMC_WR_INC_OVERRIDE          \ [0x01] converts all AHB-Lite read transactions to a series of single beat AXI transactions
  [then]


  [ifdef] AXIMC_AXIMC_M6_READ_QOS_DEF
    \
    \ @brief AXIMC master 6 read priority register
    \ Address offset: 0x48100
    \ Reset value: 0x00000004
    \
    $00 constant AXIMC_AR_QOS                   \ [0x00 : 4] read channel QoS setting
  [then]


  [ifdef] AXIMC_AXIMC_M6_WRITE_QOS_DEF
    \
    \ @brief AXIMC master 6 write priority register
    \ Address offset: 0x48104
    \ Reset value: 0x00000004
    \
    $00 constant AXIMC_AW_QOS                   \ [0x00 : 4] write channel QoS setting
  [then]


  [ifdef] AXIMC_AXIMC_M6_FN_MOD_DEF
    \
    \ @brief AXIMC master 6 issuing capability override functionality register
    \ Address offset: 0x48108
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_READ_ISS_OVERRIDE        \ [0x00] override AMIB read issuing capability
    $01 constant AXIMC_WRITE_ISS_OVERRIDE       \ [0x01] override AMIB write issuing capability
  [then]


  [ifdef] AXIMC_AXIMC_M7_READ_QOS_DEF
    \
    \ @brief AXIMC master 7 read priority register
    \ Address offset: 0x49100
    \ Reset value: 0x00000008
    \
    $00 constant AXIMC_AR_QOS                   \ [0x00 : 4] read channel QoS setting
  [then]


  [ifdef] AXIMC_AXIMC_M7_WRITE_QOS_DEF
    \
    \ @brief AXIMC master 7 write priority register
    \ Address offset: 0x49104
    \ Reset value: 0x00000008
    \
    $00 constant AXIMC_AW_QOS                   \ [0x00 : 4] write channel QoS setting
  [then]


  [ifdef] AXIMC_AXIMC_M7_FN_MOD_DEF
    \
    \ @brief AXIMC master 7 issuing capability override functionality register
    \ Address offset: 0x49108
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_READ_ISS_OVERRIDE        \ [0x00] override AMIB read issuing capability
    $01 constant AXIMC_WRITE_ISS_OVERRIDE       \ [0x01] override AMIB write issuing capability
  [then]


  [ifdef] AXIMC_AXIMC_M8_READ_QOS_DEF
    \
    \ @brief AXIMC master 8 read priority register
    \ Address offset: 0x4A100
    \ Reset value: 0x00000008
    \
    $00 constant AXIMC_AR_QOS                   \ [0x00 : 4] read channel QoS setting
  [then]


  [ifdef] AXIMC_AXIMC_M8_WRITE_QOS_DEF
    \
    \ @brief AXIMC master 8 write priority register
    \ Address offset: 0x4A104
    \ Reset value: 0x00000008
    \
    $00 constant AXIMC_AW_QOS                   \ [0x00 : 4] write channel QoS setting
  [then]


  [ifdef] AXIMC_AXIMC_M8_FN_MOD_DEF
    \
    \ @brief AXIMC master 8 issuing capability override functionality register
    \ Address offset: 0x4A108
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_READ_ISS_OVERRIDE        \ [0x00] override AMIB read issuing capability
    $01 constant AXIMC_WRITE_ISS_OVERRIDE       \ [0x01] override AMIB write issuing capability
  [then]


  [ifdef] AXIMC_AXIMC_M9_READ_QOS_DEF
    \
    \ @brief AXIMC master 9 read priority register
    \ Address offset: 0x4B100
    \ Reset value: 0x00000002
    \
    $00 constant AXIMC_AR_QOS                   \ [0x00 : 4] read channel QoS setting
  [then]


  [ifdef] AXIMC_AXIMC_M9_WRITE_QOS_DEF
    \
    \ @brief AXIMC master 9 write priority register
    \ Address offset: 0x4B104
    \ Reset value: 0x00000002
    \
    $00 constant AXIMC_AW_QOS                   \ [0x00 : 4] write channel QoS setting
  [then]


  [ifdef] AXIMC_AXIMC_M9_FN_MOD_DEF
    \
    \ @brief AXIMC master 9 issuing capability override functionality register
    \ Address offset: 0x4B108
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_READ_ISS_OVERRIDE        \ [0x00] override AMIB read issuing capability
    $01 constant AXIMC_WRITE_ISS_OVERRIDE       \ [0x01] override AMIB write issuing capability
  [then]


  [ifdef] AXIMC_AXIMC_M10_READ_QOS_DEF
    \
    \ @brief AXIMC master 10 read priority register
    \ Address offset: 0x4C100
    \ Reset value: 0x00000002
    \
    $00 constant AXIMC_AR_QOS                   \ [0x00 : 4] read channel QoS setting
  [then]


  [ifdef] AXIMC_AXIMC_M10_WRITE_QOS_DEF
    \
    \ @brief AXIMC master 10 write priority register
    \ Address offset: 0x4C104
    \ Reset value: 0x00000002
    \
    $00 constant AXIMC_AW_QOS                   \ [0x00 : 4] write channel QoS setting
  [then]


  [ifdef] AXIMC_AXIMC_M10_FN_MOD_DEF
    \
    \ @brief AXIMC master 10 issuing capability override functionality register
    \ Address offset: 0x4C108
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_READ_ISS_OVERRIDE        \ [0x00] override AMIB read issuing capability
    $01 constant AXIMC_WRITE_ISS_OVERRIDE       \ [0x01] override AMIB write issuing capability
  [then]


  [ifdef] AXIMC_AXIMC_M11_READ_QOS_DEF
    \
    \ @brief AXIMC master 11 read priority register
    \ Address offset: 0x4D100
    \ Reset value: 0x00000002
    \
    $00 constant AXIMC_AR_QOS                   \ [0x00 : 4] read channel QoS setting
  [then]


  [ifdef] AXIMC_AXIMC_M11_WRITE_QOS_DEF
    \
    \ @brief AXIMC master 11 write priority register
    \ Address offset: 0x4D104
    \ Reset value: 0x00000002
    \
    $00 constant AXIMC_AW_QOS                   \ [0x00 : 4] write channel QoS setting
  [then]


  [ifdef] AXIMC_AXIMC_M11_FN_MOD_DEF
    \
    \ @brief AXIMC master 11 issuing capability override functionality register
    \ Address offset: 0x4D108
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_READ_ISS_OVERRIDE        \ [0x00] override AMIB read issuing capability
    $01 constant AXIMC_WRITE_ISS_OVERRIDE       \ [0x01] override AMIB write issuing capability
  [then]

  \
  \ @brief AXIMC
  \
  $1FD0 constant AXIMC_AXIMC_PERIPH_ID_4    \ AXIMC peripheral ID4 register
  $1FD4 constant AXIMC_AXIMC_PERIPH_ID_5    \ AXIMC peripheral ID5 register
  $1FD8 constant AXIMC_AXIMC_PERIPH_ID_6    \ AXIMC peripheral ID6 register
  $1FDC constant AXIMC_AXIMC_PERIPH_ID_7    \ AXIMC peripheral ID7 register
  $1FE0 constant AXIMC_AXIMC_PERIPH_ID_0    \ AXIMC peripheral ID0 register
  $1FE4 constant AXIMC_AXIMC_PERIPH_ID_1    \ AXIMC peripheral ID1 register
  $1FE8 constant AXIMC_AXIMC_PERIPH_ID_2    \ AXIMC peripheral ID2 register
  $1FEC constant AXIMC_AXIMC_PERIPH_ID_3    \ AXIMC peripheral ID3 register
  $1FF0 constant AXIMC_AXIMC_COMP_ID_0  \ AXIMC component ID0 register
  $1FF4 constant AXIMC_AXIMC_COMP_ID_1  \ AXIMC component ID1 register
  $1FF8 constant AXIMC_AXIMC_COMP_ID_2  \ AXIMC component ID2 register
  $1FFC constant AXIMC_AXIMC_COMP_ID_3  \ AXIMC component ID3 register
  $42024 constant AXIMC_AXIMC_M0_FN_MOD2    \ AXIMC master 0 packing functionality register
  $42028 constant AXIMC_AXIMC_M0_FN_MOD_AHB    \ AXIMC master 0 AHB conversion override functionality register
  $42100 constant AXIMC_AXIMC_M0_READ_QOS    \ AXIMC master 0 read priority register
  $42104 constant AXIMC_AXIMC_M0_WRITE_QOS    \ AXIMC master 0 write priority register
  $42108 constant AXIMC_AXIMC_M0_FN_MOD \ AXIMC master 0 issuing capability override functionality register
  $43024 constant AXIMC_AXIMC_M1_FN_MOD2    \ AXIMC master 1 packing functionality register
  $43028 constant AXIMC_AXIMC_M1_FN_MOD_AHB    \ AXIMC master 1 AHB conversion override functionality register
  $43100 constant AXIMC_AXIMC_M1_READ_QOS    \ AXIMC master 1 read priority register
  $43104 constant AXIMC_AXIMC_M1_WRITE_QOS    \ AXIMC master 1 write priority register
  $43108 constant AXIMC_AXIMC_M1_FN_MOD \ AXIMC master 1 issuing capability override functionality register
  $44024 constant AXIMC_AXIMC_M2_FN_MOD2    \ AXIMC master 2 packing functionality register
  $44028 constant AXIMC_AXIMC_M2_FN_MOD_AHB    \ AXIMC master 2 AHB conversion override functionality register
  $44100 constant AXIMC_AXIMC_M2_READ_QOS    \ AXIMC master 2 read priority register
  $44104 constant AXIMC_AXIMC_M2_WRITE_QOS    \ AXIMC master 2 write priority register
  $44108 constant AXIMC_AXIMC_M2_FN_MOD \ AXIMC master 2 issuing capability override functionality register
  $45100 constant AXIMC_AXIMC_M3_READ_QOS    \ AXIMC master 3 read priority register
  $45104 constant AXIMC_AXIMC_M3_WRITE_QOS    \ AXIMC master 3 write priority register
  $45108 constant AXIMC_AXIMC_M3_FN_MOD \ AXIMC master 3 packing functionality register
  $4602C constant AXIMC_AXIMC_M4_FN_MOD_LB    \ AXIMC long burst capability inhibition register
  $46100 constant AXIMC_AXIMC_M4_READ_QOS    \ AXIMC master 4 read priority register
  $46104 constant AXIMC_AXIMC_M4_WRITE_QOS    \ AXIMC master 4 write priority register
  $46108 constant AXIMC_AXIMC_M4_FN_MOD \ AXIMC master 4 packing functionality register
  $47024 constant AXIMC_AXIMC_M5_FN_MOD2    \ AXIMC master 5 packing functionality register
  $47028 constant AXIMC_AXIMC_M5_FN_MOD_AHB    \ AXIMC master 5 AHB conversion override functionality register
  $47100 constant AXIMC_AXIMC_M5_READ_QOS    \ AXIMC master 5 read priority register
  $47104 constant AXIMC_AXIMC_M5_WRITE_QOS    \ AXIMC master 5 write priority register
  $47108 constant AXIMC_AXIMC_M5_FN_MOD \ AXIMC master 5 issuing capability override functionality register
  $48024 constant AXIMC_AXIMC_M6_FN_MOD2    \ AXIMC master 6 packing functionality register
  $48028 constant AXIMC_AXIMC_M6_FN_MOD_AHB    \ AXIMC master 6 AHB conversion override functionality register
  $48100 constant AXIMC_AXIMC_M6_READ_QOS    \ AXIMC master 6 read priority register
  $48104 constant AXIMC_AXIMC_M6_WRITE_QOS    \ AXIMC master 6 write priority register
  $48108 constant AXIMC_AXIMC_M6_FN_MOD \ AXIMC master 6 issuing capability override functionality register
  $49100 constant AXIMC_AXIMC_M7_READ_QOS    \ AXIMC master 7 read priority register
  $49104 constant AXIMC_AXIMC_M7_WRITE_QOS    \ AXIMC master 7 write priority register
  $49108 constant AXIMC_AXIMC_M7_FN_MOD \ AXIMC master 7 issuing capability override functionality register
  $4A100 constant AXIMC_AXIMC_M8_READ_QOS    \ AXIMC master 8 read priority register
  $4A104 constant AXIMC_AXIMC_M8_WRITE_QOS    \ AXIMC master 8 write priority register
  $4A108 constant AXIMC_AXIMC_M8_FN_MOD \ AXIMC master 8 issuing capability override functionality register
  $4B100 constant AXIMC_AXIMC_M9_READ_QOS    \ AXIMC master 9 read priority register
  $4B104 constant AXIMC_AXIMC_M9_WRITE_QOS    \ AXIMC master 9 write priority register
  $4B108 constant AXIMC_AXIMC_M9_FN_MOD \ AXIMC master 9 issuing capability override functionality register
  $4C100 constant AXIMC_AXIMC_M10_READ_QOS    \ AXIMC master 10 read priority register
  $4C104 constant AXIMC_AXIMC_M10_WRITE_QOS    \ AXIMC master 10 write priority register
  $4C108 constant AXIMC_AXIMC_M10_FN_MOD    \ AXIMC master 10 issuing capability override functionality register
  $4D100 constant AXIMC_AXIMC_M11_READ_QOS    \ AXIMC master 11 read priority register
  $4D104 constant AXIMC_AXIMC_M11_WRITE_QOS    \ AXIMC master 11 write priority register
  $4D108 constant AXIMC_AXIMC_M11_FN_MOD    \ AXIMC master 11 issuing capability override functionality register

: AXIMC_DEF ; [then]
