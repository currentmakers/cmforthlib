\
\ @file ddrctrl.fs
\ @brief DDRCTRL
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DDRCTRL_DEF

  [ifdef] DDRCTRL_DDRCTRL_MSTR_DEF
    \
    \ @brief DDRCTRL master register 0
    \ Address offset: 0x00
    \ Reset value: 0x00040001
    \
    $00 constant DDRCTRL_DDR3                   \ [0x00] DDR3
    $02 constant DDRCTRL_LPDDR2                 \ [0x02] LPDDR2
    $03 constant DDRCTRL_LPDDR3                 \ [0x03] LPDDR3
    $09 constant DDRCTRL_BURSTCHOP              \ [0x09] BURSTCHOP
    $0a constant DDRCTRL_EN_2T_TIMING_MODE      \ [0x0a] EN_2T_TIMING_MODE
    $0c constant DDRCTRL_DATA_BUS_WIDTH         \ [0x0c : 2] DATA_BUS_WIDTH
    $0f constant DDRCTRL_DLL_OFF_MODE           \ [0x0f] DLL_OFF_MODE
    $10 constant DDRCTRL_BURST_RDWR             \ [0x10 : 4] BURST_RDWR
  [then]


  [ifdef] DDRCTRL_DDRCTRL_STAT_DEF
    \
    \ @brief DDRCTRL operating mode status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_OPERATING_MODE         \ [0x00 : 3] OPERATING_MODE
    $04 constant DDRCTRL_SELFREF_TYPE           \ [0x04 : 2] SELFREF_TYPE
    $0c constant DDRCTRL_SELFREF_CAM_NOT_EMPTY  \ [0x0c] SELFREF_CAM_NOT_EMPTY
  [then]


  [ifdef] DDRCTRL_DDRCTRL_MRCTRL0_DEF
    \
    \ @brief Mode Register Read/Write Control Register 0. Do not enable more than one of the following fields simultaneously: sw_init_int pda_en mpr_en
    \ Address offset: 0x10
    \ Reset value: 0x00000010
    \
    $00 constant DDRCTRL_MR_TYPE                \ [0x00] MR_TYPE
    $04 constant DDRCTRL_MR_RANK                \ [0x04] MR_RANK
    $0c constant DDRCTRL_MR_ADDR                \ [0x0c : 4] MR_ADDR
    $1f constant DDRCTRL_MR_WR                  \ [0x1f] MR_WR
  [then]


  [ifdef] DDRCTRL_DDRCTRL_MRCTRL1_DEF
    \
    \ @brief DDRCTRL mode register read/write control register 1
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_MR_DATA                \ [0x00 : 16] MR_DATA
  [then]


  [ifdef] DDRCTRL_DDRCTRL_MRSTAT_DEF
    \
    \ @brief DDRCTRL mode register read/write status register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_MR_WR_BUSY             \ [0x00] MR_WR_BUSY
  [then]


  [ifdef] DDRCTRL_DDRCTRL_DERATEEN_DEF
    \
    \ @brief DDRCTRL temperature derate enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_DERATE_ENABLE          \ [0x00] DERATE_ENABLE
    $01 constant DDRCTRL_DERATE_VALUE           \ [0x01 : 2] DERATE_VALUE
    $04 constant DDRCTRL_DERATE_BYTE            \ [0x04 : 4] DERATE_BYTE
  [then]


  [ifdef] DDRCTRL_DDRCTRL_DERATEINT_DEF
    \
    \ @brief DDRCTRL temperature derate interval register
    \ Address offset: 0x24
    \ Reset value: 0x00800000
    \
    $00 constant DDRCTRL_MR4_READ_INTERVAL      \ [0x00 : 32] MR4_READ_INTERVAL
  [then]


  [ifdef] DDRCTRL_DDRCTRL_PWRCTL_DEF
    \
    \ @brief DDRCTRL low power control register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_SELFREF_EN             \ [0x00] SELFREF_EN
    $01 constant DDRCTRL_POWERDOWN_EN           \ [0x01] POWERDOWN_EN
    $02 constant DDRCTRL_DEEPPOWERDOWN_EN       \ [0x02] DEEPPOWERDOWN_EN
    $03 constant DDRCTRL_EN_DFI_DRAM_CLK_DISABLE     \ [0x03] EN_DFI_DRAM_CLK_DISABLE
    $05 constant DDRCTRL_SELFREF_SW             \ [0x05] SELFREF_SW
    $07 constant DDRCTRL_DIS_CAM_DRAIN_SELFREF  \ [0x07] DIS_CAM_DRAIN_SELFREF
  [then]


  [ifdef] DDRCTRL_DDRCTRL_PWRTMG_DEF
    \
    \ @brief DDRCTRL low power timing register
    \ Address offset: 0x34
    \ Reset value: 0x00402010
    \
    $00 constant DDRCTRL_POWERDOWN_TO_X32       \ [0x00 : 5] POWERDOWN_TO_X32
    $08 constant DDRCTRL_T_DPD_X4096            \ [0x08 : 8] T_DPD_X4096
    $10 constant DDRCTRL_SELFREF_TO_X32         \ [0x10 : 8] SELFREF_TO_X32
  [then]


  [ifdef] DDRCTRL_DDRCTRL_HWLPCTL_DEF
    \
    \ @brief DDRCTRL hardware low power control register
    \ Address offset: 0x38
    \ Reset value: 0x00000003
    \
    $00 constant DDRCTRL_HW_LP_EN               \ [0x00] HW_LP_EN
    $01 constant DDRCTRL_HW_LP_EXIT_IDLE_EN     \ [0x01] HW_LP_EXIT_IDLE_EN
    $10 constant DDRCTRL_HW_LP_IDLE_X32         \ [0x10 : 12] HW_LP_IDLE_X32
  [then]


  [ifdef] DDRCTRL_DDRCTRL_RFSHCTL0_DEF
    \
    \ @brief DDRCTRL refresh control register 0
    \ Address offset: 0x50
    \ Reset value: 0x00210000
    \
    $02 constant DDRCTRL_PER_BANK_REFRESH       \ [0x02] PER_BANK_REFRESH
    $04 constant DDRCTRL_REFRESH_BURST          \ [0x04 : 5] REFRESH_BURST
    $0c constant DDRCTRL_REFRESH_TO_X32         \ [0x0c : 5] REFRESH_TO_X32
    $14 constant DDRCTRL_REFRESH_MARGIN         \ [0x14 : 4] REFRESH_MARGIN
  [then]


  [ifdef] DDRCTRL_DDRCTRL_RFSHCTL3_DEF
    \
    \ @brief DDRCTRL refresh control register 3
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_DIS_AUTO_REFRESH       \ [0x00] DIS_AUTO_REFRESH
    $01 constant DDRCTRL_REFRESH_UPDATE_LEVEL   \ [0x01] REFRESH_UPDATE_LEVEL
  [then]


  [ifdef] DDRCTRL_DDRCTRL_RFSHTMG_DEF
    \
    \ @brief DDRCTRL refresh timing register
    \ Address offset: 0x64
    \ Reset value: 0x0062008C
    \
    $00 constant DDRCTRL_T_RFC_MIN              \ [0x00 : 10] T_RFC_MIN
    $0f constant DDRCTRL_LPDDR3_TREFBW_EN       \ [0x0f] LPDDR3_TREFBW_EN
    $10 constant DDRCTRL_T_RFC_NOM_X1_X32       \ [0x10 : 12] T_RFC_NOM_X1_X32
    $1f constant DDRCTRL_T_RFC_NOM_X1_SEL       \ [0x1f] T_RFC_NOM_X1_SEL
  [then]


  [ifdef] DDRCTRL_DDRCTRL_CRCPARCTL0_DEF
    \
    \ @brief DDRCTRL CRC parity control register 0
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_DFI_ALERT_ERR_INT_EN   \ [0x00] DFI_ALERT_ERR_INT_EN
    $01 constant DDRCTRL_DFI_ALERT_ERR_INT_CLR  \ [0x01] DFI_ALERT_ERR_INT_CLR
    $02 constant DDRCTRL_DFI_ALERT_ERR_CNT_CLR  \ [0x02] DFI_ALERT_ERR_CNT_CLR
  [then]


  [ifdef] DDRCTRL_DDRCTRL_CRCPARSTAT_DEF
    \
    \ @brief DDRCTRL CRC parity status register
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_DFI_ALERT_ERR_CNT      \ [0x00 : 16] DFI_ALERT_ERR_CNT
    $10 constant DDRCTRL_DFI_ALERT_ERR_INT      \ [0x10] DFI_ALERT_ERR_INT
  [then]


  [ifdef] DDRCTRL_DDRCTRL_INIT0_DEF
    \
    \ @brief DDRCTRL SDRAM initialization register 0
    \ Address offset: 0xD0
    \ Reset value: 0x0002004E
    \
    $00 constant DDRCTRL_PRE_CKE_X1024          \ [0x00 : 12] PRE_CKE_X1024
    $10 constant DDRCTRL_POST_CKE_X1024         \ [0x10 : 10] POST_CKE_X1024
    $1e constant DDRCTRL_SKIP_DRAM_INIT         \ [0x1e : 2] SKIP_DRAM_INIT
  [then]


  [ifdef] DDRCTRL_DDRCTRL_INIT1_DEF
    \
    \ @brief DDRCTRL SDRAM initialization register 1
    \ Address offset: 0xD4
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_PRE_OCD_X32            \ [0x00 : 4] PRE_OCD_X32
    $10 constant DDRCTRL_DRAM_RSTN_X1024        \ [0x10 : 9] DRAM_RSTN_X1024
  [then]


  [ifdef] DDRCTRL_DDRCTRL_INIT2_DEF
    \
    \ @brief DDRCTRL SDRAM initialization register 2
    \ Address offset: 0xD8
    \ Reset value: 0x00000D05
    \
    $00 constant DDRCTRL_MIN_STABLE_CLOCK_X1    \ [0x00 : 4] MIN_STABLE_CLOCK_X1
    $08 constant DDRCTRL_IDLE_AFTER_RESET_X32   \ [0x08 : 8] IDLE_AFTER_RESET_X32
  [then]


  [ifdef] DDRCTRL_DDRCTRL_INIT3_DEF
    \
    \ @brief DDRCTRL SDRAM initialization register 3
    \ Address offset: 0xDC
    \ Reset value: 0x00000510
    \
    $00 constant DDRCTRL_EMR                    \ [0x00 : 16] EMR
    $10 constant DDRCTRL_MR                     \ [0x10 : 16] MR
  [then]


  [ifdef] DDRCTRL_DDRCTRL_INIT4_DEF
    \
    \ @brief DDRCTRL SDRAM initialization register 4
    \ Address offset: 0xE0
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_EMR3                   \ [0x00 : 16] EMR3
    $10 constant DDRCTRL_EMR2                   \ [0x10 : 16] EMR2
  [then]


  [ifdef] DDRCTRL_DDRCTRL_INIT5_DEF
    \
    \ @brief DDRCTRL SDRAM initialization register 5
    \ Address offset: 0xE4
    \ Reset value: 0x00100004
    \
    $00 constant DDRCTRL_MAX_AUTO_INIT_X1024    \ [0x00 : 10] MAX_AUTO_INIT_X1024
    $10 constant DDRCTRL_DEV_ZQINIT_X32         \ [0x10 : 8] DEV_ZQINIT_X32
  [then]


  [ifdef] DDRCTRL_DDRCTRL_DIMMCTL_DEF
    \
    \ @brief DDRCTRL DIMM control register
    \ Address offset: 0xF0
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_DIMM_STAGGER_CS_EN     \ [0x00] DIMM_STAGGER_CS_EN
    $01 constant DDRCTRL_DIMM_ADDR_MIRR_EN      \ [0x01] DIMM_ADDR_MIRR_EN
  [then]


  [ifdef] DDRCTRL_DDRCTRL_DRAMTMG0_DEF
    \
    \ @brief DDRCTRL SDRAM timing register 0
    \ Address offset: 0x100
    \ Reset value: 0x0F101B0F
    \
    $00 constant DDRCTRL_T_RAS_MIN              \ [0x00 : 6] T_RAS_MIN
    $08 constant DDRCTRL_T_RAS_MAX              \ [0x08 : 7] T_RAS_MAX
    $10 constant DDRCTRL_T_FAW                  \ [0x10 : 6] T_FAW
    $18 constant DDRCTRL_WR2PRE                 \ [0x18 : 7] WR2PRE
  [then]


  [ifdef] DDRCTRL_DDRCTRL_DRAMTMG1_DEF
    \
    \ @brief DDRCTRL SDRAM timing register 1
    \ Address offset: 0x104
    \ Reset value: 0x00080414
    \
    $00 constant DDRCTRL_T_RC                   \ [0x00 : 7] T_RC
    $08 constant DDRCTRL_RD2PRE                 \ [0x08 : 6] RD2PRE
    $10 constant DDRCTRL_T_XP                   \ [0x10 : 5] T_XP
  [then]


  [ifdef] DDRCTRL_DDRCTRL_DRAMTMG2_DEF
    \
    \ @brief DDRCTRL SDRAM timing register 2
    \ Address offset: 0x108
    \ Reset value: 0x0305060D
    \
    $00 constant DDRCTRL_WR2RD                  \ [0x00 : 6] WR2RD
    $08 constant DDRCTRL_RD2WR                  \ [0x08 : 6] RD2WR
    $10 constant DDRCTRL_READ_LATENCY           \ [0x10 : 6] READ_LATENCY
    $18 constant DDRCTRL_WRITE_LATENCY          \ [0x18 : 6] WRITE_LATENCY
  [then]


  [ifdef] DDRCTRL_DDRCTRL_DRAMTMG3_DEF
    \
    \ @brief DDRCTRL SDRAM timing register 3
    \ Address offset: 0x10C
    \ Reset value: 0x0050400C
    \
    $00 constant DDRCTRL_T_MOD                  \ [0x00 : 10] T_MOD
    $0c constant DDRCTRL_T_MRD                  \ [0x0c : 6] T_MRD
    $14 constant DDRCTRL_T_MRW                  \ [0x14 : 10] T_MRW
  [then]


  [ifdef] DDRCTRL_DDRCTRL_DRAMTMG4_DEF
    \
    \ @brief DDRCTRL SDRAM timing register 4
    \ Address offset: 0x110
    \ Reset value: 0x05040405
    \
    $00 constant DDRCTRL_T_RP                   \ [0x00 : 5] T_RP
    $08 constant DDRCTRL_T_RRD                  \ [0x08 : 4] T_RRD
    $10 constant DDRCTRL_T_CCD                  \ [0x10 : 4] T_CCD
    $18 constant DDRCTRL_T_RCD                  \ [0x18 : 5] T_RCD
  [then]


  [ifdef] DDRCTRL_DDRCTRL_DRAMTMG5_DEF
    \
    \ @brief DDRCTRL SDRAM timing register 5
    \ Address offset: 0x114
    \ Reset value: 0x05050403
    \
    $00 constant DDRCTRL_T_CKE                  \ [0x00 : 5] T_CKE
    $08 constant DDRCTRL_T_CKESR                \ [0x08 : 6] T_CKESR
    $10 constant DDRCTRL_T_CKSRE                \ [0x10 : 4] T_CKSRE
    $18 constant DDRCTRL_T_CKSRX                \ [0x18 : 4] T_CKSRX
  [then]


  [ifdef] DDRCTRL_DDRCTRL_DRAMTMG6_DEF
    \
    \ @brief DDRCTRL SDRAM timing register 6
    \ Address offset: 0x118
    \ Reset value: 0x02020005
    \
    $00 constant DDRCTRL_T_CKCSX                \ [0x00 : 4] T_CKCSX
    $10 constant DDRCTRL_T_CKDPDX               \ [0x10 : 4] T_CKDPDX
    $18 constant DDRCTRL_T_CKDPDE               \ [0x18 : 4] T_CKDPDE
  [then]


  [ifdef] DDRCTRL_DDRCTRL_DRAMTMG7_DEF
    \
    \ @brief DDRCTRL SDRAM timing register 7
    \ Address offset: 0x11C
    \ Reset value: 0x00000202
    \
    $00 constant DDRCTRL_T_CKPDX                \ [0x00 : 4] T_CKPDX
    $08 constant DDRCTRL_T_CKPDE                \ [0x08 : 4] T_CKPDE
  [then]


  [ifdef] DDRCTRL_DDRCTRL_DRAMTMG8_DEF
    \
    \ @brief DDRCTRL SDRAM timing register 8
    \ Address offset: 0x120
    \ Reset value: 0x00004405
    \
    $00 constant DDRCTRL_T_XS_X32               \ [0x00 : 7] T_XS_X32
    $08 constant DDRCTRL_T_XS_DLL_X32           \ [0x08 : 7] T_XS_DLL_X32
  [then]


  [ifdef] DDRCTRL_DDRCTRL_DRAMTMG14_DEF
    \
    \ @brief DDRCTRL SDRAM timing register 14
    \ Address offset: 0x138
    \ Reset value: 0x000000A0
    \
    $00 constant DDRCTRL_T_XSR                  \ [0x00 : 12] T_XSR
  [then]


  [ifdef] DDRCTRL_DDRCTRL_DRAMTMG15_DEF
    \
    \ @brief DDRCTRL SDRAM timing register 15
    \ Address offset: 0x13C
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_T_STAB_X32             \ [0x00 : 8] T_STAB_X32
    $1f constant DDRCTRL_EN_DFI_LP_T_STAB       \ [0x1f] EN_DFI_LP_T_STAB
  [then]


  [ifdef] DDRCTRL_DDRCTRL_ZQCTL0_DEF
    \
    \ @brief DDRCTRL ZQ control register 0
    \ Address offset: 0x180
    \ Reset value: 0x02000040
    \
    $00 constant DDRCTRL_T_ZQ_SHORT_NOP         \ [0x00 : 10] T_ZQ_SHORT_NOP
    $10 constant DDRCTRL_T_ZQ_LONG_NOP          \ [0x10 : 11] T_ZQ_LONG_NOP
    $1d constant DDRCTRL_ZQ_RESISTOR_SHARED     \ [0x1d] ZQ_RESISTOR_SHARED
    $1e constant DDRCTRL_DIS_SRX_ZQCL           \ [0x1e] DIS_SRX_ZQCL
    $1f constant DDRCTRL_DIS_AUTO_ZQ            \ [0x1f] DIS_AUTO_ZQ
  [then]


  [ifdef] DDRCTRL_DDRCTRL_ZQCTL1_DEF
    \
    \ @brief DDRCTRL ZQ control register 1
    \ Address offset: 0x184
    \ Reset value: 0x02000100
    \
    $00 constant DDRCTRL_T_ZQ_SHORT_INTERVAL_X1024     \ [0x00 : 20] T_ZQ_SHORT_INTERVAL_X1024
    $14 constant DDRCTRL_T_ZQ_RESET_NOP         \ [0x14 : 10] T_ZQ_RESET_NOP
  [then]


  [ifdef] DDRCTRL_DDRCTRL_ZQCTL2_DEF
    \
    \ @brief DDRCTRL ZQ control register 2
    \ Address offset: 0x188
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_ZQ_RESET               \ [0x00] ZQ_RESET
  [then]


  [ifdef] DDRCTRL_DDRCTRL_ZQSTAT_DEF
    \
    \ @brief DDRCTRL ZQ status register
    \ Address offset: 0x18C
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_ZQ_RESET_BUSY          \ [0x00] ZQ_RESET_BUSY
  [then]


  [ifdef] DDRCTRL_DDRCTRL_DFITMG0_DEF
    \
    \ @brief DDRCTRL DFI timing register 0
    \ Address offset: 0x190
    \ Reset value: 0x07020002
    \
    $00 constant DDRCTRL_DFI_TPHY_WRLAT         \ [0x00 : 6] DFI_TPHY_WRLAT
    $08 constant DDRCTRL_DFI_TPHY_WRDATA        \ [0x08 : 6] DFI_TPHY_WRDATA
    $10 constant DDRCTRL_DFI_T_RDDATA_EN        \ [0x10 : 7] DFI_T_RDDATA_EN
    $18 constant DDRCTRL_DFI_T_CTRL_DELAY       \ [0x18 : 5] DFI_T_CTRL_DELAY
  [then]


  [ifdef] DDRCTRL_DDRCTRL_DFITMG1_DEF
    \
    \ @brief DDRCTRL DFI timing register 1
    \ Address offset: 0x194
    \ Reset value: 0x00000404
    \
    $00 constant DDRCTRL_DFI_T_DRAM_CLK_ENABLE  \ [0x00 : 5] DFI_T_DRAM_CLK_ENABLE
    $08 constant DDRCTRL_DFI_T_DRAM_CLK_DISABLE     \ [0x08 : 5] DFI_T_DRAM_CLK_DISABLE
    $10 constant DDRCTRL_DFI_T_WRDATA_DELAY     \ [0x10 : 5] DFI_T_WRDATA_DELAY
  [then]


  [ifdef] DDRCTRL_DDRCTRL_DFILPCFG0_DEF
    \
    \ @brief DDRCTRL low power configuration register 0
    \ Address offset: 0x198
    \ Reset value: 0x07000000
    \
    $00 constant DDRCTRL_DFI_LP_EN_PD           \ [0x00] DFI_LP_EN_PD
    $04 constant DDRCTRL_DFI_LP_WAKEUP_PD       \ [0x04 : 4] DFI_LP_WAKEUP_PD
    $08 constant DDRCTRL_DFI_LP_EN_SR           \ [0x08] DFI_LP_EN_SR
    $0c constant DDRCTRL_DFI_LP_WAKEUP_SR       \ [0x0c : 4] DFI_LP_WAKEUP_SR
    $10 constant DDRCTRL_DFI_LP_EN_DPD          \ [0x10] DFI_LP_EN_DPD
    $14 constant DDRCTRL_DFI_LP_WAKEUP_DPD      \ [0x14 : 4] DFI_LP_WAKEUP_DPD
    $18 constant DDRCTRL_DFI_TLP_RESP           \ [0x18 : 5] DFI_TLP_RESP
  [then]


  [ifdef] DDRCTRL_DDRCTRL_DFIUPD0_DEF
    \
    \ @brief DDRCTRL DFI update register 0
    \ Address offset: 0x1A0
    \ Reset value: 0x00400003
    \
    $00 constant DDRCTRL_DFI_T_CTRLUP_MIN       \ [0x00 : 10] DFI_T_CTRLUP_MIN
    $10 constant DDRCTRL_DFI_T_CTRLUP_MAX       \ [0x10 : 10] DFI_T_CTRLUP_MAX
    $1d constant DDRCTRL_CTRLUPD_PRE_SRX        \ [0x1d] CTRLUPD_PRE_SRX
    $1e constant DDRCTRL_DIS_AUTO_CTRLUPD_SRX   \ [0x1e] DIS_AUTO_CTRLUPD_SRX
    $1f constant DDRCTRL_DIS_AUTO_CTRLUPD       \ [0x1f] DIS_AUTO_CTRLUPD
  [then]


  [ifdef] DDRCTRL_DDRCTRL_DFIUPD1_DEF
    \
    \ @brief DDRCTRL DFI update register 1
    \ Address offset: 0x1A4
    \ Reset value: 0x00010001
    \
    $00 constant DDRCTRL_DFI_T_CTRLUPD_INTERVAL_MAX_X1024     \ [0x00 : 8] DFI_T_CTRLUPD_INTERVAL_MAX_X1024
    $10 constant DDRCTRL_DFI_T_CTRLUPD_INTERVAL_MIN_X1024     \ [0x10 : 8] DFI_T_CTRLUPD_INTERVAL_MIN_X1024
  [then]


  [ifdef] DDRCTRL_DDRCTRL_DFIUPD2_DEF
    \
    \ @brief DDRCTRL DFI update register 2
    \ Address offset: 0x1A8
    \ Reset value: 0x80000000
    \
    $1f constant DDRCTRL_DFI_PHYUPD_EN          \ [0x1f] DFI_PHYUPD_EN
  [then]


  [ifdef] DDRCTRL_DDRCTRL_DFIMISC_DEF
    \
    \ @brief DDRCTRL DFI miscellaneous control register
    \ Address offset: 0x1B0
    \ Reset value: 0x00000001
    \
    $00 constant DDRCTRL_DFI_INIT_COMPLETE_EN   \ [0x00] DFI_INIT_COMPLETE_EN
    $04 constant DDRCTRL_CTL_IDLE_EN            \ [0x04] CTL_IDLE_EN
    $05 constant DDRCTRL_DFI_INIT_START         \ [0x05] DFI_INIT_START
    $08 constant DDRCTRL_DFI_FREQUENCY          \ [0x08 : 5] DFI_FREQUENCY
  [then]


  [ifdef] DDRCTRL_DDRCTRL_DFISTAT_DEF
    \
    \ @brief DDRCTRL DFI status register
    \ Address offset: 0x1BC
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_DFI_INIT_COMPLETE      \ [0x00] DFI_INIT_COMPLETE
    $01 constant DDRCTRL_DFI_LP_ACK             \ [0x01] DFI_LP_ACK
  [then]


  [ifdef] DDRCTRL_DDRCTRL_DFIPHYMSTR_DEF
    \
    \ @brief DDRCTRL DFI PHY master register
    \ Address offset: 0x1C4
    \ Reset value: 0x00000001
    \
    $00 constant DDRCTRL_DFI_PHYMSTR_EN         \ [0x00] DFI_PHYMSTR_EN
  [then]


  [ifdef] DDRCTRL_DDRCTRL_ADDRMAP1_DEF
    \
    \ @brief DDRCTRL address map register 1
    \ Address offset: 0x204
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_ADDRMAP_BANK_B0        \ [0x00 : 6] ADDRMAP_BANK_B0
    $08 constant DDRCTRL_ADDRMAP_BANK_B1        \ [0x08 : 6] ADDRMAP_BANK_B1
    $10 constant DDRCTRL_ADDRMAP_BANK_B2        \ [0x10 : 6] ADDRMAP_BANK_B2
  [then]


  [ifdef] DDRCTRL_DDRCTRL_ADDRMAP2_DEF
    \
    \ @brief DDRCTRL address map register 2
    \ Address offset: 0x208
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_ADDRMAP_COL_B2         \ [0x00 : 4] ADDRMAP_COL_B2
    $08 constant DDRCTRL_ADDRMAP_COL_B3         \ [0x08 : 4] ADDRMAP_COL_B3
    $10 constant DDRCTRL_ADDRMAP_COL_B4         \ [0x10 : 4] ADDRMAP_COL_B4
    $18 constant DDRCTRL_ADDRMAP_COL_B5         \ [0x18 : 4] ADDRMAP_COL_B5
  [then]


  [ifdef] DDRCTRL_DDRCTRL_ADDRMAP3_DEF
    \
    \ @brief DDRCTRL address map register 3
    \ Address offset: 0x20C
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_ADDRMAP_COL_B6         \ [0x00 : 4] ADDRMAP_COL_B6
    $08 constant DDRCTRL_ADDRMAP_COL_B7         \ [0x08 : 5] ADDRMAP_COL_B7
    $10 constant DDRCTRL_ADDRMAP_COL_B8         \ [0x10 : 5] ADDRMAP_COL_B8
    $18 constant DDRCTRL_ADDRMAP_COL_B9         \ [0x18 : 5] ADDRMAP_COL_B9
  [then]


  [ifdef] DDRCTRL_DDRCTRL_ADDRMAP4_DEF
    \
    \ @brief DDRCTRL address map register 4
    \ Address offset: 0x210
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_ADDRMAP_COL_B10        \ [0x00 : 5] ADDRMAP_COL_B10
    $08 constant DDRCTRL_ADDRMAP_COL_B11        \ [0x08 : 5] ADDRMAP_COL_B11
  [then]


  [ifdef] DDRCTRL_DDRCTRL_ADDRMAP5_DEF
    \
    \ @brief DDRCTRL address map register 5
    \ Address offset: 0x214
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_ADDRMAP_ROW_B0         \ [0x00 : 4] ADDRMAP_ROW_B0
    $08 constant DDRCTRL_ADDRMAP_ROW_B1         \ [0x08 : 4] ADDRMAP_ROW_B1
    $10 constant DDRCTRL_ADDRMAP_ROW_B2_10      \ [0x10 : 4] ADDRMAP_ROW_B2_10
    $18 constant DDRCTRL_ADDRMAP_ROW_B11        \ [0x18 : 4] ADDRMAP_ROW_B11
  [then]


  [ifdef] DDRCTRL_DDRCTRL_ADDRMAP6_DEF
    \
    \ @brief DDRCTRL address register 6
    \ Address offset: 0x218
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_ADDRMAP_ROW_B12        \ [0x00 : 4] ADDRMAP_ROW_B12
    $08 constant DDRCTRL_ADDRMAP_ROW_B13        \ [0x08 : 4] ADDRMAP_ROW_B13
    $10 constant DDRCTRL_ADDRMAP_ROW_B14        \ [0x10 : 4] ADDRMAP_ROW_B14
    $18 constant DDRCTRL_ADDRMAP_ROW_B15        \ [0x18 : 4] ADDRMAP_ROW_B15
    $1f constant DDRCTRL_LPDDR3_6GB_12GB        \ [0x1f] LPDDR3_6GB_12GB
  [then]


  [ifdef] DDRCTRL_DDRCTRL_ADDRMAP9_DEF
    \
    \ @brief DDRCTRL address map register 9
    \ Address offset: 0x224
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_ADDRMAP_ROW_B2         \ [0x00 : 4] ADDRMAP_ROW_B2
    $08 constant DDRCTRL_ADDRMAP_ROW_B3         \ [0x08 : 4] ADDRMAP_ROW_B3
    $10 constant DDRCTRL_ADDRMAP_ROW_B4         \ [0x10 : 4] ADDRMAP_ROW_B4
    $18 constant DDRCTRL_ADDRMAP_ROW_B5         \ [0x18 : 4] ADDRMAP_ROW_B5
  [then]


  [ifdef] DDRCTRL_DDRCTRL_ADDRMAP10_DEF
    \
    \ @brief DDRCTRL address map register 10
    \ Address offset: 0x228
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_ADDRMAP_ROW_B6         \ [0x00 : 4] ADDRMAP_ROW_B6
    $08 constant DDRCTRL_ADDRMAP_ROW_B7         \ [0x08 : 4] ADDRMAP_ROW_B7
    $10 constant DDRCTRL_ADDRMAP_ROW_B8         \ [0x10 : 4] ADDRMAP_ROW_B8
    $18 constant DDRCTRL_ADDRMAP_ROW_B9         \ [0x18 : 4] ADDRMAP_ROW_B9
  [then]


  [ifdef] DDRCTRL_DDRCTRL_ADDRMAP11_DEF
    \
    \ @brief DDRCTRL address map register 11
    \ Address offset: 0x22C
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_ADDRMAP_ROW_B10        \ [0x00 : 4] ADDRMAP_ROW_B10
  [then]


  [ifdef] DDRCTRL_DDRCTRL_ODTCFG_DEF
    \
    \ @brief DDRCTRL ODT configuration register
    \ Address offset: 0x240
    \ Reset value: 0x04000400
    \
    $02 constant DDRCTRL_RD_ODT_DELAY           \ [0x02 : 5] RD_ODT_DELAY
    $08 constant DDRCTRL_RD_ODT_HOLD            \ [0x08 : 4] RD_ODT_HOLD
    $10 constant DDRCTRL_WR_ODT_DELAY           \ [0x10 : 5] WR_ODT_DELAY
    $18 constant DDRCTRL_WR_ODT_HOLD            \ [0x18 : 4] WR_ODT_HOLD
  [then]


  [ifdef] DDRCTRL_DDRCTRL_ODTMAP_DEF
    \
    \ @brief DDRCTRL ODT/Rank map register
    \ Address offset: 0x244
    \ Reset value: 0x00000011
    \
    $00 constant DDRCTRL_RANK0_WR_ODT           \ [0x00] RANK0_WR_ODT
    $04 constant DDRCTRL_RANK0_RD_ODT           \ [0x04] RANK0_RD_ODT
  [then]


  [ifdef] DDRCTRL_DDRCTRL_SCHED_DEF
    \
    \ @brief DDRCTRL scheduler control register
    \ Address offset: 0x250
    \ Reset value: 0x00000805
    \
    $00 constant DDRCTRL_FORCE_LOW_PRI_N        \ [0x00] FORCE_LOW_PRI_N
    $01 constant DDRCTRL_PREFER_WRITE           \ [0x01] PREFER_WRITE
    $02 constant DDRCTRL_PAGECLOSE              \ [0x02] PAGECLOSE
    $08 constant DDRCTRL_LPR_NUM_ENTRIES        \ [0x08 : 4] LPR_NUM_ENTRIES
    $10 constant DDRCTRL_GO2CRITICAL_HYSTERESIS     \ [0x10 : 8] GO2CRITICAL_HYSTERESIS
    $18 constant DDRCTRL_RDWR_IDLE_GAP          \ [0x18 : 7] RDWR_IDLE_GAP
  [then]


  [ifdef] DDRCTRL_DDRCTRL_SCHED1_DEF
    \
    \ @brief DDRCTRL scheduler control register 1
    \ Address offset: 0x254
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_PAGECLOSE_TIMER        \ [0x00 : 8] PAGECLOSE_TIMER
  [then]


  [ifdef] DDRCTRL_DDRCTRL_PERFHPR1_DEF
    \
    \ @brief DDRCTRL high priority read CAM register 1
    \ Address offset: 0x25C
    \ Reset value: 0x0F000001
    \
    $00 constant DDRCTRL_HPR_MAX_STARVE         \ [0x00 : 16] HPR_MAX_STARVE
    $18 constant DDRCTRL_HPR_XACT_RUN_LENGTH    \ [0x18 : 8] HPR_XACT_RUN_LENGTH
  [then]


  [ifdef] DDRCTRL_DDRCTRL_PERFLPR1_DEF
    \
    \ @brief DDRCTRL low priority read CAM register 1
    \ Address offset: 0x264
    \ Reset value: 0x0F00007F
    \
    $00 constant DDRCTRL_LPR_MAX_STARVE         \ [0x00 : 16] LPR_MAX_STARVE
    $18 constant DDRCTRL_LPR_XACT_RUN_LENGTH    \ [0x18 : 8] LPR_XACT_RUN_LENGTH
  [then]


  [ifdef] DDRCTRL_DDRCTRL_PERFWR1_DEF
    \
    \ @brief DDRCTRL write CAM register 1
    \ Address offset: 0x26C
    \ Reset value: 0x0F00007F
    \
    $00 constant DDRCTRL_W_MAX_STARVE           \ [0x00 : 16] W_MAX_STARVE
    $18 constant DDRCTRL_W_XACT_RUN_LENGTH      \ [0x18 : 8] W_XACT_RUN_LENGTH
  [then]


  [ifdef] DDRCTRL_DDRCTRL_DBG0_DEF
    \
    \ @brief DDRCTRL debug register 0
    \ Address offset: 0x300
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_DIS_WC                 \ [0x00] DIS_WC
    $04 constant DDRCTRL_DIS_COLLISION_PAGE_OPT     \ [0x04] DIS_COLLISION_PAGE_OPT
  [then]


  [ifdef] DDRCTRL_DDRCTRL_DBG1_DEF
    \
    \ @brief DDRCTRL debug register 1
    \ Address offset: 0x304
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_DIS_DQ                 \ [0x00] DIS_DQ
    $01 constant DDRCTRL_DIS_HIF                \ [0x01] DIS_HIF
  [then]


  [ifdef] DDRCTRL_DDRCTRL_DBGCAM_DEF
    \
    \ @brief DDRCTRL CAM debug register
    \ Address offset: 0x308
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_DBG_HPR_Q_DEPTH        \ [0x00 : 5] DBG_HPR_Q_DEPTH
    $08 constant DDRCTRL_DBG_LPR_Q_DEPTH        \ [0x08 : 5] DBG_LPR_Q_DEPTH
    $10 constant DDRCTRL_DBG_W_Q_DEPTH          \ [0x10 : 5] DBG_W_Q_DEPTH
    $18 constant DDRCTRL_DBG_STALL              \ [0x18] DBG_STALL
    $19 constant DDRCTRL_DBG_RD_Q_EMPTY         \ [0x19] DBG_RD_Q_EMPTY
    $1a constant DDRCTRL_DBG_WR_Q_EMPTY         \ [0x1a] DBG_WR_Q_EMPTY
    $1c constant DDRCTRL_RD_DATA_PIPELINE_EMPTY     \ [0x1c] RD_DATA_PIPELINE_EMPTY
    $1d constant DDRCTRL_WR_DATA_PIPELINE_EMPTY     \ [0x1d] WR_DATA_PIPELINE_EMPTY
  [then]


  [ifdef] DDRCTRL_DDRCTRL_DBGCMD_DEF
    \
    \ @brief DDRCTRL command debug register
    \ Address offset: 0x30C
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_RANK0_REFRESH          \ [0x00] RANK0_REFRESH
    $04 constant DDRCTRL_ZQ_CALIB_SHORT         \ [0x04] ZQ_CALIB_SHORT
    $05 constant DDRCTRL_CTRLUPD                \ [0x05] CTRLUPD
  [then]


  [ifdef] DDRCTRL_DDRCTRL_DBGSTAT_DEF
    \
    \ @brief DDRCTRL status debug register
    \ Address offset: 0x310
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_RANK0_REFRESH_BUSY     \ [0x00] RANK0_REFRESH_BUSY
    $04 constant DDRCTRL_ZQ_CALIB_SHORT_BUSY    \ [0x04] ZQ_CALIB_SHORT_BUSY
    $05 constant DDRCTRL_CTRLUPD_BUSY           \ [0x05] CTRLUPD_BUSY
  [then]


  [ifdef] DDRCTRL_DDRCTRL_SWCTL_DEF
    \
    \ @brief DDRCTRL software register programming control enable
    \ Address offset: 0x320
    \ Reset value: 0x00000001
    \
    $00 constant DDRCTRL_SW_DONE                \ [0x00] SW_DONE
  [then]


  [ifdef] DDRCTRL_DDRCTRL_SWSTAT_DEF
    \
    \ @brief DDRCTRL software register programming control status
    \ Address offset: 0x324
    \ Reset value: 0x00000001
    \
    $00 constant DDRCTRL_SW_DONE_ACK            \ [0x00] SW_DONE_ACK
  [then]


  [ifdef] DDRCTRL_DDRCTRL_POISONCFG_DEF
    \
    \ @brief AXI Poison configuration register common for all AXI ports.
    \ Address offset: 0x36C
    \ Reset value: 0x00110011
    \
    $00 constant DDRCTRL_WR_POISON_SLVERR_EN    \ [0x00] WR_POISON_SLVERR_EN
    $04 constant DDRCTRL_WR_POISON_INTR_EN      \ [0x04] WR_POISON_INTR_EN
    $08 constant DDRCTRL_WR_POISON_INTR_CLR     \ [0x08] WR_POISON_INTR_CLR
    $10 constant DDRCTRL_RD_POISON_SLVERR_EN    \ [0x10] RD_POISON_SLVERR_EN
    $14 constant DDRCTRL_RD_POISON_INTR_EN      \ [0x14] RD_POISON_INTR_EN
    $18 constant DDRCTRL_RD_POISON_INTR_CLR     \ [0x18] RD_POISON_INTR_CLR
  [then]


  [ifdef] DDRCTRL_DDRCTRL_POISONSTAT_DEF
    \
    \ @brief DDRCTRL AXI Poison status register
    \ Address offset: 0x370
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_WR_POISON_INTR_0       \ [0x00] WR_POISON_INTR_0
    $01 constant DDRCTRL_WR_POISON_INTR_1       \ [0x01] WR_POISON_INTR_1
    $10 constant DDRCTRL_RD_POISON_INTR_0       \ [0x10] RD_POISON_INTR_0
    $11 constant DDRCTRL_RD_POISON_INTR_1       \ [0x11] RD_POISON_INTR_1
  [then]


  [ifdef] DDRCTRL_DDRCTRL_PSTAT_DEF
    \
    \ @brief DDRCTRL port status register
    \ Address offset: 0x3FC
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_RD_PORT_BUSY_0         \ [0x00] RD_PORT_BUSY_0
    $01 constant DDRCTRL_RD_PORT_BUSY_1         \ [0x01] RD_PORT_BUSY_1
    $10 constant DDRCTRL_WR_PORT_BUSY_0         \ [0x10] WR_PORT_BUSY_0
    $11 constant DDRCTRL_WR_PORT_BUSY_1         \ [0x11] WR_PORT_BUSY_1
  [then]


  [ifdef] DDRCTRL_DDRCTRL_PCCFG_DEF
    \
    \ @brief DDRCTRL port common configuration register
    \ Address offset: 0x400
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_GO2CRITICAL_EN         \ [0x00] GO2CRITICAL_EN
    $04 constant DDRCTRL_PAGEMATCH_LIMIT        \ [0x04] PAGEMATCH_LIMIT
    $08 constant DDRCTRL_BL_EXP_MODE            \ [0x08] BL_EXP_MODE
  [then]


  [ifdef] DDRCTRL_DDRCTRL_PCFGR_0_DEF
    \
    \ @brief DDRCTRL port 0 configuration read register
    \ Address offset: 0x404
    \ Reset value: 0x00004000
    \
    $00 constant DDRCTRL_RD_PORT_PRIORITY       \ [0x00 : 10] RD_PORT_PRIORITY
    $0c constant DDRCTRL_RD_PORT_AGING_EN       \ [0x0c] RD_PORT_AGING_EN
    $0d constant DDRCTRL_RD_PORT_URGENT_EN      \ [0x0d] RD_PORT_URGENT_EN
    $0e constant DDRCTRL_RD_PORT_PAGEMATCH_EN   \ [0x0e] RD_PORT_PAGEMATCH_EN
    $10 constant DDRCTRL_RDWR_ORDERED_EN        \ [0x10] RDWR_ORDERED_EN
  [then]


  [ifdef] DDRCTRL_DDRCTRL_PCFGW_0_DEF
    \
    \ @brief DDRCTRL port 0 configuration write register
    \ Address offset: 0x408
    \ Reset value: 0x00004000
    \
    $00 constant DDRCTRL_WR_PORT_PRIORITY       \ [0x00 : 10] WR_PORT_PRIORITY
    $0c constant DDRCTRL_WR_PORT_AGING_EN       \ [0x0c] WR_PORT_AGING_EN
    $0d constant DDRCTRL_WR_PORT_URGENT_EN      \ [0x0d] WR_PORT_URGENT_EN
    $0e constant DDRCTRL_WR_PORT_PAGEMATCH_EN   \ [0x0e] WR_PORT_PAGEMATCH_EN
  [then]


  [ifdef] DDRCTRL_DDRCTRL_PCTRL_0_DEF
    \
    \ @brief DDRCTRL port 0 control register
    \ Address offset: 0x490
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_PORT_EN                \ [0x00] PORT_EN
  [then]


  [ifdef] DDRCTRL_DDRCTRL_PCFGQOS0_0_DEF
    \
    \ @brief DDRCTRL port 0 read Q0S configuration register 0
    \ Address offset: 0x494
    \ Reset value: 0x02000E00
    \
    $00 constant DDRCTRL_RQOS_MAP_LEVEL1        \ [0x00 : 4] RQOS_MAP_LEVEL1
    $08 constant DDRCTRL_RQOS_MAP_LEVEL2        \ [0x08 : 4] RQOS_MAP_LEVEL2
    $10 constant DDRCTRL_RQOS_MAP_REGION0       \ [0x10 : 2] RQOS_MAP_REGION0
    $14 constant DDRCTRL_RQOS_MAP_REGION1       \ [0x14 : 2] RQOS_MAP_REGION1
    $18 constant DDRCTRL_RQOS_MAP_REGION2       \ [0x18 : 2] RQOS_MAP_REGION2
  [then]


  [ifdef] DDRCTRL_DDRCTRL_PCFGQOS1_0_DEF
    \
    \ @brief DDRCTRL port 0 read Q0S configuration register 1
    \ Address offset: 0x498
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_RQOS_MAP_TIMEOUTB      \ [0x00 : 11] RQOS_MAP_TIMEOUTB
    $10 constant DDRCTRL_RQOS_MAP_TIMEOUTR      \ [0x10 : 11] RQOS_MAP_TIMEOUTR
  [then]


  [ifdef] DDRCTRL_DDRCTRL_PCFGWQOS0_0_DEF
    \
    \ @brief DDRCTRL port 0 write Q0S configuration register 0
    \ Address offset: 0x49C
    \ Reset value: 0x00000E00
    \
    $00 constant DDRCTRL_WQOS_MAP_LEVEL1        \ [0x00 : 4] WQOS_MAP_LEVEL1
    $08 constant DDRCTRL_WQOS_MAP_LEVEL2        \ [0x08 : 4] WQOS_MAP_LEVEL2
    $10 constant DDRCTRL_WQOS_MAP_REGION0       \ [0x10 : 2] WQOS_MAP_REGION0
    $14 constant DDRCTRL_WQOS_MAP_REGION1       \ [0x14 : 2] WQOS_MAP_REGION1
    $18 constant DDRCTRL_WQOS_MAP_REGION2       \ [0x18 : 2] WQOS_MAP_REGION2
  [then]


  [ifdef] DDRCTRL_DDRCTRL_PCFGWQOS1_0_DEF
    \
    \ @brief DDRCTRL port 0 write Q0S configuration register 1
    \ Address offset: 0x4A0
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_WQOS_MAP_TIMEOUT1      \ [0x00 : 11] WQOS_MAP_TIMEOUT1
    $10 constant DDRCTRL_WQOS_MAP_TIMEOUT2      \ [0x10 : 11] WQOS_MAP_TIMEOUT2
  [then]


  [ifdef] DDRCTRL_DDRCTRL_PCFGR_1_DEF
    \
    \ @brief DDRCTRL port 1 configuration read register
    \ Address offset: 0x4B4
    \ Reset value: 0x00004000
    \
    $00 constant DDRCTRL_RD_PORT_PRIORITY       \ [0x00 : 10] RD_PORT_PRIORITY
    $0c constant DDRCTRL_RD_PORT_AGING_EN       \ [0x0c] RD_PORT_AGING_EN
    $0d constant DDRCTRL_RD_PORT_URGENT_EN      \ [0x0d] RD_PORT_URGENT_EN
    $0e constant DDRCTRL_RD_PORT_PAGEMATCH_EN   \ [0x0e] RD_PORT_PAGEMATCH_EN
    $10 constant DDRCTRL_RDWR_ORDERED_EN        \ [0x10] RDWR_ORDERED_EN
  [then]


  [ifdef] DDRCTRL_DDRCTRL_PCFGW_1_DEF
    \
    \ @brief DDRCTRL port 1 configuration write register
    \ Address offset: 0x4B8
    \ Reset value: 0x00004000
    \
    $00 constant DDRCTRL_WR_PORT_PRIORITY       \ [0x00 : 10] WR_PORT_PRIORITY
    $0c constant DDRCTRL_WR_PORT_AGING_EN       \ [0x0c] WR_PORT_AGING_EN
    $0d constant DDRCTRL_WR_PORT_URGENT_EN      \ [0x0d] WR_PORT_URGENT_EN
    $0e constant DDRCTRL_WR_PORT_PAGEMATCH_EN   \ [0x0e] WR_PORT_PAGEMATCH_EN
  [then]


  [ifdef] DDRCTRL_DDRCTRL_PCTRL_1_DEF
    \
    \ @brief DDRCTRL port 1 control register
    \ Address offset: 0x540
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_PORT_EN                \ [0x00] PORT_EN
  [then]


  [ifdef] DDRCTRL_DDRCTRL_PCFGQOS0_1_DEF
    \
    \ @brief DDRCTRL port 1 read Q0S configuration register 0
    \ Address offset: 0x544
    \ Reset value: 0x02000E00
    \
    $00 constant DDRCTRL_RQOS_MAP_LEVEL1        \ [0x00 : 4] RQOS_MAP_LEVEL1
    $08 constant DDRCTRL_RQOS_MAP_LEVEL2        \ [0x08 : 4] RQOS_MAP_LEVEL2
    $10 constant DDRCTRL_RQOS_MAP_REGION0       \ [0x10 : 2] RQOS_MAP_REGION0
    $14 constant DDRCTRL_RQOS_MAP_REGION1       \ [0x14 : 2] RQOS_MAP_REGION1
    $18 constant DDRCTRL_RQOS_MAP_REGION2       \ [0x18 : 2] RQOS_MAP_REGION2
  [then]


  [ifdef] DDRCTRL_DDRCTRL_PCFGQOS1_1_DEF
    \
    \ @brief DDRCTRL port 1 read Q0S configuration register 1
    \ Address offset: 0x548
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_RQOS_MAP_TIMEOUTB      \ [0x00 : 11] RQOS_MAP_TIMEOUTB
    $10 constant DDRCTRL_RQOS_MAP_TIMEOUTR      \ [0x10 : 11] RQOS_MAP_TIMEOUTR
  [then]


  [ifdef] DDRCTRL_DDRCTRL_PCFGWQOS0_1_DEF
    \
    \ @brief DDRCTRL port 1 write Q0S configuration register 0
    \ Address offset: 0x54C
    \ Reset value: 0x00000E00
    \
    $00 constant DDRCTRL_WQOS_MAP_LEVEL1        \ [0x00 : 4] WQOS_MAP_LEVEL1
    $08 constant DDRCTRL_WQOS_MAP_LEVEL2        \ [0x08 : 4] WQOS_MAP_LEVEL2
    $10 constant DDRCTRL_WQOS_MAP_REGION0       \ [0x10 : 2] WQOS_MAP_REGION0
    $14 constant DDRCTRL_WQOS_MAP_REGION1       \ [0x14 : 2] WQOS_MAP_REGION1
    $18 constant DDRCTRL_WQOS_MAP_REGION2       \ [0x18 : 2] WQOS_MAP_REGION2
  [then]


  [ifdef] DDRCTRL_DDRCTRL_PCFGWQOS1_1_DEF
    \
    \ @brief DDRCTRL port 1 write Q0S configuration register 1
    \ Address offset: 0x550
    \ Reset value: 0x00000000
    \
    $00 constant DDRCTRL_WQOS_MAP_TIMEOUT1      \ [0x00 : 11] WQOS_MAP_TIMEOUT1
    $10 constant DDRCTRL_WQOS_MAP_TIMEOUT2      \ [0x10 : 11] WQOS_MAP_TIMEOUT2
  [then]

  \
  \ @brief DDRCTRL
  \
  $00 constant DDRCTRL_DDRCTRL_MSTR     \ DDRCTRL master register 0
  $04 constant DDRCTRL_DDRCTRL_STAT     \ DDRCTRL operating mode status register
  $10 constant DDRCTRL_DDRCTRL_MRCTRL0  \ Mode Register Read/Write Control Register 0. Do not enable more than one of the following fields simultaneously: sw_init_int pda_en mpr_en
  $14 constant DDRCTRL_DDRCTRL_MRCTRL1  \ DDRCTRL mode register read/write control register 1
  $18 constant DDRCTRL_DDRCTRL_MRSTAT   \ DDRCTRL mode register read/write status register
  $20 constant DDRCTRL_DDRCTRL_DERATEEN \ DDRCTRL temperature derate enable register
  $24 constant DDRCTRL_DDRCTRL_DERATEINT    \ DDRCTRL temperature derate interval register
  $30 constant DDRCTRL_DDRCTRL_PWRCTL   \ DDRCTRL low power control register
  $34 constant DDRCTRL_DDRCTRL_PWRTMG   \ DDRCTRL low power timing register
  $38 constant DDRCTRL_DDRCTRL_HWLPCTL  \ DDRCTRL hardware low power control register
  $50 constant DDRCTRL_DDRCTRL_RFSHCTL0 \ DDRCTRL refresh control register 0
  $60 constant DDRCTRL_DDRCTRL_RFSHCTL3 \ DDRCTRL refresh control register 3
  $64 constant DDRCTRL_DDRCTRL_RFSHTMG  \ DDRCTRL refresh timing register
  $C0 constant DDRCTRL_DDRCTRL_CRCPARCTL0    \ DDRCTRL CRC parity control register 0
  $CC constant DDRCTRL_DDRCTRL_CRCPARSTAT    \ DDRCTRL CRC parity status register
  $D0 constant DDRCTRL_DDRCTRL_INIT0    \ DDRCTRL SDRAM initialization register 0
  $D4 constant DDRCTRL_DDRCTRL_INIT1    \ DDRCTRL SDRAM initialization register 1
  $D8 constant DDRCTRL_DDRCTRL_INIT2    \ DDRCTRL SDRAM initialization register 2
  $DC constant DDRCTRL_DDRCTRL_INIT3    \ DDRCTRL SDRAM initialization register 3
  $E0 constant DDRCTRL_DDRCTRL_INIT4    \ DDRCTRL SDRAM initialization register 4
  $E4 constant DDRCTRL_DDRCTRL_INIT5    \ DDRCTRL SDRAM initialization register 5
  $F0 constant DDRCTRL_DDRCTRL_DIMMCTL  \ DDRCTRL DIMM control register
  $100 constant DDRCTRL_DDRCTRL_DRAMTMG0    \ DDRCTRL SDRAM timing register 0
  $104 constant DDRCTRL_DDRCTRL_DRAMTMG1    \ DDRCTRL SDRAM timing register 1
  $108 constant DDRCTRL_DDRCTRL_DRAMTMG2    \ DDRCTRL SDRAM timing register 2
  $10C constant DDRCTRL_DDRCTRL_DRAMTMG3    \ DDRCTRL SDRAM timing register 3
  $110 constant DDRCTRL_DDRCTRL_DRAMTMG4    \ DDRCTRL SDRAM timing register 4
  $114 constant DDRCTRL_DDRCTRL_DRAMTMG5    \ DDRCTRL SDRAM timing register 5
  $118 constant DDRCTRL_DDRCTRL_DRAMTMG6    \ DDRCTRL SDRAM timing register 6
  $11C constant DDRCTRL_DDRCTRL_DRAMTMG7    \ DDRCTRL SDRAM timing register 7
  $120 constant DDRCTRL_DDRCTRL_DRAMTMG8    \ DDRCTRL SDRAM timing register 8
  $138 constant DDRCTRL_DDRCTRL_DRAMTMG14    \ DDRCTRL SDRAM timing register 14
  $13C constant DDRCTRL_DDRCTRL_DRAMTMG15    \ DDRCTRL SDRAM timing register 15
  $180 constant DDRCTRL_DDRCTRL_ZQCTL0  \ DDRCTRL ZQ control register 0
  $184 constant DDRCTRL_DDRCTRL_ZQCTL1  \ DDRCTRL ZQ control register 1
  $188 constant DDRCTRL_DDRCTRL_ZQCTL2  \ DDRCTRL ZQ control register 2
  $18C constant DDRCTRL_DDRCTRL_ZQSTAT  \ DDRCTRL ZQ status register
  $190 constant DDRCTRL_DDRCTRL_DFITMG0 \ DDRCTRL DFI timing register 0
  $194 constant DDRCTRL_DDRCTRL_DFITMG1 \ DDRCTRL DFI timing register 1
  $198 constant DDRCTRL_DDRCTRL_DFILPCFG0    \ DDRCTRL low power configuration register 0
  $1A0 constant DDRCTRL_DDRCTRL_DFIUPD0 \ DDRCTRL DFI update register 0
  $1A4 constant DDRCTRL_DDRCTRL_DFIUPD1 \ DDRCTRL DFI update register 1
  $1A8 constant DDRCTRL_DDRCTRL_DFIUPD2 \ DDRCTRL DFI update register 2
  $1B0 constant DDRCTRL_DDRCTRL_DFIMISC \ DDRCTRL DFI miscellaneous control register
  $1BC constant DDRCTRL_DDRCTRL_DFISTAT \ DDRCTRL DFI status register
  $1C4 constant DDRCTRL_DDRCTRL_DFIPHYMSTR    \ DDRCTRL DFI PHY master register
  $204 constant DDRCTRL_DDRCTRL_ADDRMAP1    \ DDRCTRL address map register 1
  $208 constant DDRCTRL_DDRCTRL_ADDRMAP2    \ DDRCTRL address map register 2
  $20C constant DDRCTRL_DDRCTRL_ADDRMAP3    \ DDRCTRL address map register 3
  $210 constant DDRCTRL_DDRCTRL_ADDRMAP4    \ DDRCTRL address map register 4
  $214 constant DDRCTRL_DDRCTRL_ADDRMAP5    \ DDRCTRL address map register 5
  $218 constant DDRCTRL_DDRCTRL_ADDRMAP6    \ DDRCTRL address register 6
  $224 constant DDRCTRL_DDRCTRL_ADDRMAP9    \ DDRCTRL address map register 9
  $228 constant DDRCTRL_DDRCTRL_ADDRMAP10    \ DDRCTRL address map register 10
  $22C constant DDRCTRL_DDRCTRL_ADDRMAP11    \ DDRCTRL address map register 11
  $240 constant DDRCTRL_DDRCTRL_ODTCFG  \ DDRCTRL ODT configuration register
  $244 constant DDRCTRL_DDRCTRL_ODTMAP  \ DDRCTRL ODT/Rank map register
  $250 constant DDRCTRL_DDRCTRL_SCHED   \ DDRCTRL scheduler control register
  $254 constant DDRCTRL_DDRCTRL_SCHED1  \ DDRCTRL scheduler control register 1
  $25C constant DDRCTRL_DDRCTRL_PERFHPR1    \ DDRCTRL high priority read CAM register 1
  $264 constant DDRCTRL_DDRCTRL_PERFLPR1    \ DDRCTRL low priority read CAM register 1
  $26C constant DDRCTRL_DDRCTRL_PERFWR1 \ DDRCTRL write CAM register 1
  $300 constant DDRCTRL_DDRCTRL_DBG0    \ DDRCTRL debug register 0
  $304 constant DDRCTRL_DDRCTRL_DBG1    \ DDRCTRL debug register 1
  $308 constant DDRCTRL_DDRCTRL_DBGCAM  \ DDRCTRL CAM debug register
  $30C constant DDRCTRL_DDRCTRL_DBGCMD  \ DDRCTRL command debug register
  $310 constant DDRCTRL_DDRCTRL_DBGSTAT \ DDRCTRL status debug register
  $320 constant DDRCTRL_DDRCTRL_SWCTL   \ DDRCTRL software register programming control enable
  $324 constant DDRCTRL_DDRCTRL_SWSTAT  \ DDRCTRL software register programming control status
  $36C constant DDRCTRL_DDRCTRL_POISONCFG    \ AXI Poison configuration register common for all AXI ports.
  $370 constant DDRCTRL_DDRCTRL_POISONSTAT    \ DDRCTRL AXI Poison status register
  $3FC constant DDRCTRL_DDRCTRL_PSTAT   \ DDRCTRL port status register
  $400 constant DDRCTRL_DDRCTRL_PCCFG   \ DDRCTRL port common configuration register
  $404 constant DDRCTRL_DDRCTRL_PCFGR_0 \ DDRCTRL port 0 configuration read register
  $408 constant DDRCTRL_DDRCTRL_PCFGW_0 \ DDRCTRL port 0 configuration write register
  $490 constant DDRCTRL_DDRCTRL_PCTRL_0 \ DDRCTRL port 0 control register
  $494 constant DDRCTRL_DDRCTRL_PCFGQOS0_0    \ DDRCTRL port 0 read Q0S configuration register 0
  $498 constant DDRCTRL_DDRCTRL_PCFGQOS1_0    \ DDRCTRL port 0 read Q0S configuration register 1
  $49C constant DDRCTRL_DDRCTRL_PCFGWQOS0_0    \ DDRCTRL port 0 write Q0S configuration register 0
  $4A0 constant DDRCTRL_DDRCTRL_PCFGWQOS1_0    \ DDRCTRL port 0 write Q0S configuration register 1
  $4B4 constant DDRCTRL_DDRCTRL_PCFGR_1 \ DDRCTRL port 1 configuration read register
  $4B8 constant DDRCTRL_DDRCTRL_PCFGW_1 \ DDRCTRL port 1 configuration write register
  $540 constant DDRCTRL_DDRCTRL_PCTRL_1 \ DDRCTRL port 1 control register
  $544 constant DDRCTRL_DDRCTRL_PCFGQOS0_1    \ DDRCTRL port 1 read Q0S configuration register 0
  $548 constant DDRCTRL_DDRCTRL_PCFGQOS1_1    \ DDRCTRL port 1 read Q0S configuration register 1
  $54C constant DDRCTRL_DDRCTRL_PCFGWQOS0_1    \ DDRCTRL port 1 write Q0S configuration register 0
  $550 constant DDRCTRL_DDRCTRL_PCFGWQOS1_1    \ DDRCTRL port 1 write Q0S configuration register 1

: DDRCTRL_DEF ; [then]
