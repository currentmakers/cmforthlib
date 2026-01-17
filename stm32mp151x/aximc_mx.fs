\
\ @file aximc_mx.fs
\ @brief AXIMC_Mx
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] AXIMC_MX_DEF

  [ifdef] AXIMC_MX_AXIMC_M0_FN_MOD2_DEF
    \
    \ @brief AXIMC master 0 packing functionality register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_MX_BYPASS_MERGE          \ [0x00] BYPASS_MERGE
  [then]


  [ifdef] AXIMC_MX_AXIMC_M0_READ_QOS_DEF
    \
    \ @brief AXIMC master 0 read priority register
    \ Address offset: 0xDC
    \ Reset value: 0x00000006
    \
    $00 constant AXIMC_MX_AR_QOS                \ [0x00 : 4] AR_QOS
  [then]


  [ifdef] AXIMC_MX_AXIMC_M0_FN_MOD_DEF
    \
    \ @brief AXIMC master 0 issuing capability override functionality register
    \ Address offset: 0xE0
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_MX_READ_ISS_OVERRIDE     \ [0x00] READ_ISS_OVERRIDE
    $01 constant AXIMC_MX_WRITE_ISS_OVERRIDE    \ [0x01] WRITE_ISS_OVERRIDE
  [then]


  [ifdef] AXIMC_MX_AXIMC_M0_WRITE_QOS_DEF
    \
    \ @brief AXIMC master 0 write priority register
    \ Address offset: 0xE4
    \ Reset value: 0x00000006
    \
    $00 constant AXIMC_MX_AW_QOS                \ [0x00 : 4] AW_QOS
  [then]


  [ifdef] AXIMC_MX_AXIMC_M1_FN_MOD2_DEF
    \
    \ @brief AXIMC master 1 packing functionality register
    \ Address offset: 0x1000
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_MX_BYPASS_MERGE          \ [0x00] BYPASS_MERGE
  [then]


  [ifdef] AXIMC_MX_AXIMC_M1_READ_QOS_DEF
    \
    \ @brief AXIMC master 1 read priority register
    \ Address offset: 0x10DC
    \ Reset value: 0x00000006
    \
    $00 constant AXIMC_MX_AR_QOS                \ [0x00 : 4] AR_QOS
  [then]


  [ifdef] AXIMC_MX_AXIMC_M1_WRITE_QOS_DEF
    \
    \ @brief AXIMC master 1 write priority register
    \ Address offset: 0x10E0
    \ Reset value: 0x00000006
    \
    $00 constant AXIMC_MX_AW_QOS                \ [0x00 : 4] AW_QOS
  [then]


  [ifdef] AXIMC_MX_AXIMC_M1_FN_MOD_DEF
    \
    \ @brief AXIMC master 1 issuing capability override functionality register
    \ Address offset: 0x10E4
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_MX_READ_ISS_OVERRIDE     \ [0x00] READ_ISS_OVERRIDE
    $01 constant AXIMC_MX_WRITE_ISS_OVERRIDE    \ [0x01] WRITE_ISS_OVERRIDE
  [then]


  [ifdef] AXIMC_MX_AXIMC_PERIPH_ID_4_DEF
    \
    \ @brief AXIMC peripheral ID4 register
    \ Address offset: 0x1FD0
    \ Reset value: 0x00000004
    \
    $00 constant AXIMC_MX_JEP106CON             \ [0x00 : 4] JEP106CON
    $04 constant AXIMC_MX_K4COUNT               \ [0x04 : 4] K4COUNT
  [then]


  [ifdef] AXIMC_MX_AXIMC_PERIPH_ID_5_DEF
    \
    \ @brief AXIMC peripheral ID5 register
    \ Address offset: 0x1FD4
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_MX_PERIPH_ID_5           \ [0x00 : 8] PERIPH_ID_5
  [then]


  [ifdef] AXIMC_MX_AXIMC_PERIPH_ID_6_DEF
    \
    \ @brief AXIMC peripheral ID6 register
    \ Address offset: 0x1FD8
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_MX_PERIPH_ID_6           \ [0x00 : 8] PERIPH_ID_6
  [then]


  [ifdef] AXIMC_MX_AXIMC_PERIPH_ID_7_DEF
    \
    \ @brief AXIMC peripheral ID7 register
    \ Address offset: 0x1FDC
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_MX_PERIPH_ID_7           \ [0x00 : 8] PERIPH_ID_7
  [then]


  [ifdef] AXIMC_MX_AXIMC_PERIPH_ID_0_DEF
    \
    \ @brief AXIMC peripheral ID0 register
    \ Address offset: 0x1FE0
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_MX_PERIPH_ID_0           \ [0x00 : 8] PERIPH_ID_0
  [then]


  [ifdef] AXIMC_MX_AXIMC_PERIPH_ID_1_DEF
    \
    \ @brief AXIMC peripheral ID1 register
    \ Address offset: 0x1FE4
    \ Reset value: 0x000000B4
    \
    $00 constant AXIMC_MX_PERIPH_ID_1           \ [0x00 : 8] PERIPH_ID_1
  [then]


  [ifdef] AXIMC_MX_AXIMC_PERIPH_ID_2_DEF
    \
    \ @brief AXIMC peripheral ID2 register
    \ Address offset: 0x1FE8
    \ Reset value: 0x0000003B
    \
    $00 constant AXIMC_MX_PERIPH_ID_2           \ [0x00 : 8] PERIPH_ID_2
  [then]


  [ifdef] AXIMC_MX_AXIMC_PERIPH_ID_3_DEF
    \
    \ @brief AXIMC peripheral ID3 register
    \ Address offset: 0x1FEC
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_MX_CUST_MOD_NUM          \ [0x00 : 4] CUST_MOD_NUM
    $04 constant AXIMC_MX_REV_AND               \ [0x04 : 4] REV_AND
  [then]


  [ifdef] AXIMC_MX_AXIMC_COMP_ID_0_DEF
    \
    \ @brief AXIMC component ID0 register
    \ Address offset: 0x1FF0
    \ Reset value: 0x0000000D
    \
    $00 constant AXIMC_MX_PREAMBLE              \ [0x00 : 8] PREAMBLE
  [then]


  [ifdef] AXIMC_MX_AXIMC_COMP_ID_1_DEF
    \
    \ @brief AXIMC component ID1 register
    \ Address offset: 0x1FF4
    \ Reset value: 0x000000F0
    \
    $00 constant AXIMC_MX_PREAMBLE              \ [0x00 : 4] PREAMBLE
    $04 constant AXIMC_MX_CLASS                 \ [0x04 : 4] CLASS
  [then]


  [ifdef] AXIMC_MX_AXIMC_COMP_ID_2_DEF
    \
    \ @brief AXIMC component ID2 register
    \ Address offset: 0x1FF8
    \ Reset value: 0x00000005
    \
    $00 constant AXIMC_MX_PREAMBLE              \ [0x00 : 8] PREAMBLE
  [then]


  [ifdef] AXIMC_MX_AXIMC_COMP_ID_3_DEF
    \
    \ @brief AXIMC component ID3 register
    \ Address offset: 0x1FFC
    \ Reset value: 0x000000B1
    \
    $00 constant AXIMC_MX_PREAMBLE              \ [0x00 : 8] PREAMBLE
  [then]


  [ifdef] AXIMC_MX_AXIMC_M2_FN_MOD2_DEF
    \
    \ @brief AXIMC master 2 packing functionality register
    \ Address offset: 0x2000
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_MX_BYPASS_MERGE          \ [0x00] BYPASS_MERGE
  [then]


  [ifdef] AXIMC_MX_AXIMC_M2_READ_QOS_DEF
    \
    \ @brief AXIMC master 2 read priority register
    \ Address offset: 0x20DC
    \ Reset value: 0x00000006
    \
    $00 constant AXIMC_MX_AR_QOS                \ [0x00 : 4] AR_QOS
  [then]


  [ifdef] AXIMC_MX_AXIMC_M2_WRITE_QOS_DEF
    \
    \ @brief AXIMC master 2 write priority register
    \ Address offset: 0x20E0
    \ Reset value: 0x00000006
    \
    $00 constant AXIMC_MX_AW_QOS                \ [0x00 : 4] AW_QOS
  [then]


  [ifdef] AXIMC_MX_AXIMC_M2_FN_MOD_DEF
    \
    \ @brief AXIMC master 2 issuing capability override functionality register
    \ Address offset: 0x20E4
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_MX_READ_ISS_OVERRIDE     \ [0x00] READ_ISS_OVERRIDE
    $01 constant AXIMC_MX_WRITE_ISS_OVERRIDE    \ [0x01] WRITE_ISS_OVERRIDE
  [then]


  [ifdef] AXIMC_MX_AXIMC_M5_FN_MOD2_DEF
    \
    \ @brief AXIMC master 5 packing functionality register
    \ Address offset: 0x3000
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_MX_BYPASS_MERGE          \ [0x00] BYPASS_MERGE
  [then]


  [ifdef] AXIMC_MX_AXIMC_M5_READ_QOS_DEF
    \
    \ @brief AXIMC master 5 read priority register
    \ Address offset: 0x30DC
    \ Reset value: 0x00000004
    \
    $00 constant AXIMC_MX_AR_QOS                \ [0x00 : 4] AR_QOS
  [then]


  [ifdef] AXIMC_MX_AXIMC_M5_WRITE_QOS_DEF
    \
    \ @brief AXIMC master 5 write priority register
    \ Address offset: 0x30E0
    \ Reset value: 0x00000004
    \
    $00 constant AXIMC_MX_AW_QOS                \ [0x00 : 4] AW_QOS
  [then]


  [ifdef] AXIMC_MX_AXIMC_M5_FN_MOD_DEF
    \
    \ @brief AXIMC master 5 issuing capability override functionality register
    \ Address offset: 0x30E4
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_MX_READ_ISS_OVERRIDE     \ [0x00] READ_ISS_OVERRIDE
    $01 constant AXIMC_MX_WRITE_ISS_OVERRIDE    \ [0x01] WRITE_ISS_OVERRIDE
  [then]


  [ifdef] AXIMC_MX_AXIMC_M3_READ_QOS_DEF
    \
    \ @brief AXIMC master 3 read priority register
    \ Address offset: 0x40DC
    \ Reset value: 0x00000007
    \
    $00 constant AXIMC_MX_AR_QOS                \ [0x00 : 4] AR_QOS
  [then]


  [ifdef] AXIMC_MX_AXIMC_M3_WRITE_QOS_DEF
    \
    \ @brief AXIMC master 3 write priority register
    \ Address offset: 0x40E0
    \ Reset value: 0x00000007
    \
    $00 constant AXIMC_MX_AW_QOS                \ [0x00 : 4] AW_QOS
  [then]


  [ifdef] AXIMC_MX_AXIMC_M3_FN_MOD_DEF
    \
    \ @brief AXIMC master 3 packing functionality register
    \ Address offset: 0x40E4
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_MX_READ_ISS_OVERRIDE     \ [0x00] READ_ISS_OVERRIDE
    $01 constant AXIMC_MX_WRITE_ISS_OVERRIDE    \ [0x01] WRITE_ISS_OVERRIDE
  [then]


  [ifdef] AXIMC_MX_AXIMC_M7_READ_QOS_DEF
    \
    \ @brief AXIMC master 7 read priority register
    \ Address offset: 0x50DC
    \ Reset value: 0x00000008
    \
    $00 constant AXIMC_MX_AR_QOS                \ [0x00 : 4] AR_QOS
  [then]


  [ifdef] AXIMC_MX_AXIMC_M7_WRITE_QOS_DEF
    \
    \ @brief AXIMC master 7 write priority register
    \ Address offset: 0x50E0
    \ Reset value: 0x00000008
    \
    $00 constant AXIMC_MX_AW_QOS                \ [0x00 : 4] AW_QOS
  [then]


  [ifdef] AXIMC_MX_AXIMC_M7_FN_MOD_DEF
    \
    \ @brief AXIMC master 7 issuing capability override functionality register
    \ Address offset: 0x50E4
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_MX_READ_ISS_OVERRIDE     \ [0x00] READ_ISS_OVERRIDE
    $01 constant AXIMC_MX_WRITE_ISS_OVERRIDE    \ [0x01] WRITE_ISS_OVERRIDE
  [then]


  [ifdef] AXIMC_MX_AXIMC_M8_READ_QOS_DEF
    \
    \ @brief AXIMC master 8 read priority register
    \ Address offset: 0x60DC
    \ Reset value: 0x00000008
    \
    $00 constant AXIMC_MX_AR_QOS                \ [0x00 : 4] AR_QOS
  [then]


  [ifdef] AXIMC_MX_AXIMC_M8_WRITE_QOS_DEF
    \
    \ @brief AXIMC master 8 write priority register
    \ Address offset: 0x60E0
    \ Reset value: 0x00000008
    \
    $00 constant AXIMC_MX_AW_QOS                \ [0x00 : 4] AW_QOS
  [then]


  [ifdef] AXIMC_MX_AXIMC_M8_FN_MOD_DEF
    \
    \ @brief AXIMC master 8 issuing capability override functionality register
    \ Address offset: 0x60E4
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_MX_READ_ISS_OVERRIDE     \ [0x00] READ_ISS_OVERRIDE
    $01 constant AXIMC_MX_WRITE_ISS_OVERRIDE    \ [0x01] WRITE_ISS_OVERRIDE
  [then]


  [ifdef] AXIMC_MX_AXIMC_M4_FN_MOD2_DEF
    \
    \ @brief AXIMC master 4 packing functionality register
    \ Address offset: 0x8000
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_MX_BYPASS_MERGE          \ [0x00] BYPASS_MERGE
  [then]


  [ifdef] AXIMC_MX_AXIMC_M4_READ_QOS_DEF
    \
    \ @brief AXIMC master 4 read priority register
    \ Address offset: 0x80DC
    \ Reset value: 0x00000007
    \
    $00 constant AXIMC_MX_AR_QOS                \ [0x00 : 4] AR_QOS
  [then]


  [ifdef] AXIMC_MX_AXIMC_M4_WRITE_QOS_DEF
    \
    \ @brief AXIMC master 4 write priority register
    \ Address offset: 0x80E0
    \ Reset value: 0x00000007
    \
    $00 constant AXIMC_MX_AW_QOS                \ [0x00 : 4] AW_QOS
  [then]


  [ifdef] AXIMC_MX_AXIMC_M4_FN_MOD_DEF
    \
    \ @brief AXIMC master 4 packing functionality register
    \ Address offset: 0x80E4
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_MX_READ_ISS_OVERRIDE     \ [0x00] READ_ISS_OVERRIDE
    $01 constant AXIMC_MX_WRITE_ISS_OVERRIDE    \ [0x01] WRITE_ISS_OVERRIDE
  [then]


  [ifdef] AXIMC_MX_AXIMC_M9_READ_QOS_DEF
    \
    \ @brief AXIMC master 9 read priority register
    \ Address offset: 0x90DC
    \ Reset value: 0x0000000B
    \
    $00 constant AXIMC_MX_AR_QOS                \ [0x00 : 4] AR_QOS
  [then]


  [ifdef] AXIMC_MX_AXIMC_M9_WRITE_QOS_DEF
    \
    \ @brief AXIMC master 9 write priority register
    \ Address offset: 0x90E0
    \ Reset value: 0x0000000B
    \
    $00 constant AXIMC_MX_AW_QOS                \ [0x00 : 4] AW_QOS
  [then]


  [ifdef] AXIMC_MX_AXIMC_M9_FN_MOD_DEF
    \
    \ @brief AXIMC master 9 issuing capability override functionality register
    \ Address offset: 0x90E4
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_MX_READ_ISS_OVERRIDE     \ [0x00] READ_ISS_OVERRIDE
    $01 constant AXIMC_MX_WRITE_ISS_OVERRIDE    \ [0x01] WRITE_ISS_OVERRIDE
  [then]


  [ifdef] AXIMC_MX_AXIMC_M10_READ_QOS_DEF
    \
    \ @brief AXIMC master 10 read priority register
    \ Address offset: 0xA0DC
    \ Reset value: 0x0000000B
    \
    $00 constant AXIMC_MX_AR_QOS                \ [0x00 : 4] AR_QOS
  [then]


  [ifdef] AXIMC_MX_AXIMC_M10_WRITE_QOS_DEF
    \
    \ @brief AXIMC master 10 write priority register
    \ Address offset: 0xA0E0
    \ Reset value: 0x0000000B
    \
    $00 constant AXIMC_MX_AW_QOS                \ [0x00 : 4] AW_QOS
  [then]


  [ifdef] AXIMC_MX_AXIMC_M10_FN_MOD_DEF
    \
    \ @brief AXIMC master 10 issuing capability override functionality register
    \ Address offset: 0xA0E4
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_MX_READ_ISS_OVERRIDE     \ [0x00] READ_ISS_OVERRIDE
    $01 constant AXIMC_MX_WRITE_ISS_OVERRIDE    \ [0x01] WRITE_ISS_OVERRIDE
  [then]


  [ifdef] AXIMC_MX_AXIMC_M6_FN_MOD2_DEF
    \
    \ @brief AXIMC master 6 packing functionality register
    \ Address offset: 0xB000
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_MX_BYPASS_MERGE          \ [0x00] BYPASS_MERGE
  [then]


  [ifdef] AXIMC_MX_AXIMC_M6_READ_QOS_DEF
    \
    \ @brief AXIMC master 6 read priority register
    \ Address offset: 0xB0DC
    \ Reset value: 0x00000004
    \
    $00 constant AXIMC_MX_AR_QOS                \ [0x00 : 4] AR_QOS
  [then]


  [ifdef] AXIMC_MX_AXIMC_M6_WRITE_QOS_DEF
    \
    \ @brief AXIMC master 6 write priority register
    \ Address offset: 0xB0E0
    \ Reset value: 0x00000004
    \
    $00 constant AXIMC_MX_AW_QOS                \ [0x00 : 4] AW_QOS
  [then]


  [ifdef] AXIMC_MX_AXIMC_M6_FN_MOD_DEF
    \
    \ @brief AXIMC master 6 issuing capability override functionality register
    \ Address offset: 0xB0E4
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_MX_READ_ISS_OVERRIDE     \ [0x00] READ_ISS_OVERRIDE
    $01 constant AXIMC_MX_WRITE_ISS_OVERRIDE    \ [0x01] WRITE_ISS_OVERRIDE
  [then]


  [ifdef] AXIMC_MX_AXIMC_M0_FN_MOD_AHB_DEF
    \
    \ @brief AXIMC master 0 AHB conversion override functionality register
    \ Address offset: 0x42028
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_MX_RD_INC_OVERRIDE       \ [0x00] RD_INC_OVERRIDE
    $01 constant AXIMC_MX_WR_INC_OVERRIDE       \ [0x01] WR_INC_OVERRIDE
  [then]


  [ifdef] AXIMC_MX_AXIMC_M1_FN_MOD_AHB_DEF
    \
    \ @brief AXIMC master 1 AHB conversion override functionality register
    \ Address offset: 0x43028
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_MX_RD_INC_OVERRIDE       \ [0x00] RD_INC_OVERRIDE
    $01 constant AXIMC_MX_WR_INC_OVERRIDE       \ [0x01] WR_INC_OVERRIDE
  [then]


  [ifdef] AXIMC_MX_AXIMC_M2_FN_MOD_AHB_DEF
    \
    \ @brief AXIMC master 2 AHB conversion override functionality register
    \ Address offset: 0x44028
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_MX_RD_INC_OVERRIDE       \ [0x00] RD_INC_OVERRIDE
    $01 constant AXIMC_MX_WR_INC_OVERRIDE       \ [0x01] WR_INC_OVERRIDE
  [then]


  [ifdef] AXIMC_MX_AXIMC_M5_FN_MOD_AHB_DEF
    \
    \ @brief AXIMC master 5 AHB conversion override functionality register
    \ Address offset: 0x45028
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_MX_RD_INC_OVERRIDE       \ [0x00] RD_INC_OVERRIDE
    $01 constant AXIMC_MX_WR_INC_OVERRIDE       \ [0x01] WR_INC_OVERRIDE
  [then]


  [ifdef] AXIMC_MX_AXIMC_FN_MOD_LB_DEF
    \
    \ @brief AXIMC long burst capability inhibition register
    \ Address offset: 0x4A02C
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_MX_FN_MOD_LB             \ [0x00] FN_MOD_LB
  [then]


  [ifdef] AXIMC_MX_AXIMC_M6_FN_MOD_AHB_DEF
    \
    \ @brief AXIMC master 6 AHB conversion override functionality register
    \ Address offset: 0x4D028
    \ Reset value: 0x00000000
    \
    $00 constant AXIMC_MX_RD_INC_OVERRIDE       \ [0x00] RD_INC_OVERRIDE
    $01 constant AXIMC_MX_WR_INC_OVERRIDE       \ [0x01] WR_INC_OVERRIDE
  [then]

  \
  \ @brief AXIMC_Mx
  \
  $00 constant AXIMC_MX_AXIMC_M0_FN_MOD2    \ AXIMC master 0 packing functionality register
  $DC constant AXIMC_MX_AXIMC_M0_READ_QOS    \ AXIMC master 0 read priority register
  $E0 constant AXIMC_MX_AXIMC_M0_FN_MOD \ AXIMC master 0 issuing capability override functionality register
  $E4 constant AXIMC_MX_AXIMC_M0_WRITE_QOS    \ AXIMC master 0 write priority register
  $1000 constant AXIMC_MX_AXIMC_M1_FN_MOD2    \ AXIMC master 1 packing functionality register
  $10DC constant AXIMC_MX_AXIMC_M1_READ_QOS    \ AXIMC master 1 read priority register
  $10E0 constant AXIMC_MX_AXIMC_M1_WRITE_QOS    \ AXIMC master 1 write priority register
  $10E4 constant AXIMC_MX_AXIMC_M1_FN_MOD    \ AXIMC master 1 issuing capability override functionality register
  $1FD0 constant AXIMC_MX_AXIMC_PERIPH_ID_4    \ AXIMC peripheral ID4 register
  $1FD4 constant AXIMC_MX_AXIMC_PERIPH_ID_5    \ AXIMC peripheral ID5 register
  $1FD8 constant AXIMC_MX_AXIMC_PERIPH_ID_6    \ AXIMC peripheral ID6 register
  $1FDC constant AXIMC_MX_AXIMC_PERIPH_ID_7    \ AXIMC peripheral ID7 register
  $1FE0 constant AXIMC_MX_AXIMC_PERIPH_ID_0    \ AXIMC peripheral ID0 register
  $1FE4 constant AXIMC_MX_AXIMC_PERIPH_ID_1    \ AXIMC peripheral ID1 register
  $1FE8 constant AXIMC_MX_AXIMC_PERIPH_ID_2    \ AXIMC peripheral ID2 register
  $1FEC constant AXIMC_MX_AXIMC_PERIPH_ID_3    \ AXIMC peripheral ID3 register
  $1FF0 constant AXIMC_MX_AXIMC_COMP_ID_0    \ AXIMC component ID0 register
  $1FF4 constant AXIMC_MX_AXIMC_COMP_ID_1    \ AXIMC component ID1 register
  $1FF8 constant AXIMC_MX_AXIMC_COMP_ID_2    \ AXIMC component ID2 register
  $1FFC constant AXIMC_MX_AXIMC_COMP_ID_3    \ AXIMC component ID3 register
  $2000 constant AXIMC_MX_AXIMC_M2_FN_MOD2    \ AXIMC master 2 packing functionality register
  $20DC constant AXIMC_MX_AXIMC_M2_READ_QOS    \ AXIMC master 2 read priority register
  $20E0 constant AXIMC_MX_AXIMC_M2_WRITE_QOS    \ AXIMC master 2 write priority register
  $20E4 constant AXIMC_MX_AXIMC_M2_FN_MOD    \ AXIMC master 2 issuing capability override functionality register
  $3000 constant AXIMC_MX_AXIMC_M5_FN_MOD2    \ AXIMC master 5 packing functionality register
  $30DC constant AXIMC_MX_AXIMC_M5_READ_QOS    \ AXIMC master 5 read priority register
  $30E0 constant AXIMC_MX_AXIMC_M5_WRITE_QOS    \ AXIMC master 5 write priority register
  $30E4 constant AXIMC_MX_AXIMC_M5_FN_MOD    \ AXIMC master 5 issuing capability override functionality register
  $40DC constant AXIMC_MX_AXIMC_M3_READ_QOS    \ AXIMC master 3 read priority register
  $40E0 constant AXIMC_MX_AXIMC_M3_WRITE_QOS    \ AXIMC master 3 write priority register
  $40E4 constant AXIMC_MX_AXIMC_M3_FN_MOD    \ AXIMC master 3 packing functionality register
  $50DC constant AXIMC_MX_AXIMC_M7_READ_QOS    \ AXIMC master 7 read priority register
  $50E0 constant AXIMC_MX_AXIMC_M7_WRITE_QOS    \ AXIMC master 7 write priority register
  $50E4 constant AXIMC_MX_AXIMC_M7_FN_MOD    \ AXIMC master 7 issuing capability override functionality register
  $60DC constant AXIMC_MX_AXIMC_M8_READ_QOS    \ AXIMC master 8 read priority register
  $60E0 constant AXIMC_MX_AXIMC_M8_WRITE_QOS    \ AXIMC master 8 write priority register
  $60E4 constant AXIMC_MX_AXIMC_M8_FN_MOD    \ AXIMC master 8 issuing capability override functionality register
  $8000 constant AXIMC_MX_AXIMC_M4_FN_MOD2    \ AXIMC master 4 packing functionality register
  $80DC constant AXIMC_MX_AXIMC_M4_READ_QOS    \ AXIMC master 4 read priority register
  $80E0 constant AXIMC_MX_AXIMC_M4_WRITE_QOS    \ AXIMC master 4 write priority register
  $80E4 constant AXIMC_MX_AXIMC_M4_FN_MOD    \ AXIMC master 4 packing functionality register
  $90DC constant AXIMC_MX_AXIMC_M9_READ_QOS    \ AXIMC master 9 read priority register
  $90E0 constant AXIMC_MX_AXIMC_M9_WRITE_QOS    \ AXIMC master 9 write priority register
  $90E4 constant AXIMC_MX_AXIMC_M9_FN_MOD    \ AXIMC master 9 issuing capability override functionality register
  $A0DC constant AXIMC_MX_AXIMC_M10_READ_QOS    \ AXIMC master 10 read priority register
  $A0E0 constant AXIMC_MX_AXIMC_M10_WRITE_QOS    \ AXIMC master 10 write priority register
  $A0E4 constant AXIMC_MX_AXIMC_M10_FN_MOD    \ AXIMC master 10 issuing capability override functionality register
  $B000 constant AXIMC_MX_AXIMC_M6_FN_MOD2    \ AXIMC master 6 packing functionality register
  $B0DC constant AXIMC_MX_AXIMC_M6_READ_QOS    \ AXIMC master 6 read priority register
  $B0E0 constant AXIMC_MX_AXIMC_M6_WRITE_QOS    \ AXIMC master 6 write priority register
  $B0E4 constant AXIMC_MX_AXIMC_M6_FN_MOD    \ AXIMC master 6 issuing capability override functionality register
  $42028 constant AXIMC_MX_AXIMC_M0_FN_MOD_AHB    \ AXIMC master 0 AHB conversion override functionality register
  $43028 constant AXIMC_MX_AXIMC_M1_FN_MOD_AHB    \ AXIMC master 1 AHB conversion override functionality register
  $44028 constant AXIMC_MX_AXIMC_M2_FN_MOD_AHB    \ AXIMC master 2 AHB conversion override functionality register
  $45028 constant AXIMC_MX_AXIMC_M5_FN_MOD_AHB    \ AXIMC master 5 AHB conversion override functionality register
  $4A02C constant AXIMC_MX_AXIMC_FN_MOD_LB    \ AXIMC long burst capability inhibition register
  $4D028 constant AXIMC_MX_AXIMC_M6_FN_MOD_AHB    \ AXIMC master 6 AHB conversion override functionality register

: AXIMC_MX_DEF ; [then]
