\
\ @file ddrctrl.fs
\ @brief DDRCTRL
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DDRCTRL master register 0
\ Address offset: 0x00
\ Reset value: 0x00040001
\

$00000001 constant DDRCTRL_DDRCTRL_MSTR_DDR3                        \ DDR3
$00000004 constant DDRCTRL_DDRCTRL_MSTR_LPDDR2                      \ LPDDR2
$00000008 constant DDRCTRL_DDRCTRL_MSTR_LPDDR3                      \ LPDDR3
$00000200 constant DDRCTRL_DDRCTRL_MSTR_BURSTCHOP                   \ BURSTCHOP
$00000400 constant DDRCTRL_DDRCTRL_MSTR_EN_2T_TIMING_MODE           \ EN_2T_TIMING_MODE
$00003000 constant DDRCTRL_DDRCTRL_MSTR_DATA_BUS_WIDTH              \ DATA_BUS_WIDTH
$00008000 constant DDRCTRL_DDRCTRL_MSTR_DLL_OFF_MODE                \ DLL_OFF_MODE
$000f0000 constant DDRCTRL_DDRCTRL_MSTR_BURST_RDWR                  \ BURST_RDWR


\
\ @brief DDRCTRL operating mode status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000007 constant DDRCTRL_DDRCTRL_STAT_OPERATING_MODE              \ OPERATING_MODE
$00000030 constant DDRCTRL_DDRCTRL_STAT_SELFREF_TYPE                \ SELFREF_TYPE
$00001000 constant DDRCTRL_DDRCTRL_STAT_SELFREF_CAM_NOT_EMPTY       \ SELFREF_CAM_NOT_EMPTY


\
\ @brief Mode Register Read/Write Control Register 0. Do not enable more than one of the following fields simultaneously: sw_init_int pda_en mpr_en
\ Address offset: 0x10
\ Reset value: 0x00000010
\

$00000001 constant DDRCTRL_DDRCTRL_MRCTRL0_MR_TYPE                  \ MR_TYPE
$00000010 constant DDRCTRL_DDRCTRL_MRCTRL0_MR_RANK                  \ MR_RANK
$0000f000 constant DDRCTRL_DDRCTRL_MRCTRL0_MR_ADDR                  \ MR_ADDR
$80000000 constant DDRCTRL_DDRCTRL_MRCTRL0_MR_WR                    \ MR_WR


\
\ @brief DDRCTRL mode register read/write control register 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant DDRCTRL_DDRCTRL_MRCTRL1_MR_DATA                  \ MR_DATA


\
\ @brief DDRCTRL mode register read/write status register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant DDRCTRL_DDRCTRL_MRSTAT_MR_WR_BUSY                \ MR_WR_BUSY


\
\ @brief DDRCTRL temperature derate enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant DDRCTRL_DDRCTRL_DERATEEN_DERATE_ENABLE           \ DERATE_ENABLE
$00000006 constant DDRCTRL_DDRCTRL_DERATEEN_DERATE_VALUE            \ DERATE_VALUE
$000000f0 constant DDRCTRL_DDRCTRL_DERATEEN_DERATE_BYTE             \ DERATE_BYTE


\
\ @brief DDRCTRL temperature derate interval register
\ Address offset: 0x24
\ Reset value: 0x00800000
\

$00000000 constant DDRCTRL_DDRCTRL_DERATEINT_MR4_READ_INTERVAL      \ MR4_READ_INTERVAL


\
\ @brief DDRCTRL low power control register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant DDRCTRL_DDRCTRL_PWRCTL_SELFREF_EN                \ SELFREF_EN
$00000002 constant DDRCTRL_DDRCTRL_PWRCTL_POWERDOWN_EN              \ POWERDOWN_EN
$00000004 constant DDRCTRL_DDRCTRL_PWRCTL_DEEPPOWERDOWN_EN          \ DEEPPOWERDOWN_EN
$00000008 constant DDRCTRL_DDRCTRL_PWRCTL_EN_DFI_DRAM_CLK_DISABLE    \ EN_DFI_DRAM_CLK_DISABLE
$00000020 constant DDRCTRL_DDRCTRL_PWRCTL_SELFREF_SW                \ SELFREF_SW
$00000080 constant DDRCTRL_DDRCTRL_PWRCTL_DIS_CAM_DRAIN_SELFREF     \ DIS_CAM_DRAIN_SELFREF


\
\ @brief DDRCTRL low power timing register
\ Address offset: 0x34
\ Reset value: 0x00402010
\

$0000001f constant DDRCTRL_DDRCTRL_PWRTMG_POWERDOWN_TO_X32          \ POWERDOWN_TO_X32
$0000ff00 constant DDRCTRL_DDRCTRL_PWRTMG_T_DPD_X4096               \ T_DPD_X4096
$00ff0000 constant DDRCTRL_DDRCTRL_PWRTMG_SELFREF_TO_X32            \ SELFREF_TO_X32


\
\ @brief DDRCTRL hardware low power control register
\ Address offset: 0x38
\ Reset value: 0x00000003
\

$00000001 constant DDRCTRL_DDRCTRL_HWLPCTL_HW_LP_EN                 \ HW_LP_EN
$00000002 constant DDRCTRL_DDRCTRL_HWLPCTL_HW_LP_EXIT_IDLE_EN       \ HW_LP_EXIT_IDLE_EN
$0fff0000 constant DDRCTRL_DDRCTRL_HWLPCTL_HW_LP_IDLE_X32           \ HW_LP_IDLE_X32


\
\ @brief DDRCTRL refresh control register 0
\ Address offset: 0x50
\ Reset value: 0x00210000
\

$00000004 constant DDRCTRL_DDRCTRL_RFSHCTL0_PER_BANK_REFRESH        \ PER_BANK_REFRESH
$000001f0 constant DDRCTRL_DDRCTRL_RFSHCTL0_REFRESH_BURST           \ REFRESH_BURST
$0001f000 constant DDRCTRL_DDRCTRL_RFSHCTL0_REFRESH_TO_X32          \ REFRESH_TO_X32
$00f00000 constant DDRCTRL_DDRCTRL_RFSHCTL0_REFRESH_MARGIN          \ REFRESH_MARGIN


\
\ @brief DDRCTRL refresh control register 3
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000001 constant DDRCTRL_DDRCTRL_RFSHCTL3_DIS_AUTO_REFRESH        \ DIS_AUTO_REFRESH
$00000002 constant DDRCTRL_DDRCTRL_RFSHCTL3_REFRESH_UPDATE_LEVEL    \ REFRESH_UPDATE_LEVEL


\
\ @brief DDRCTRL refresh timing register
\ Address offset: 0x64
\ Reset value: 0x0062008C
\

$000003ff constant DDRCTRL_DDRCTRL_RFSHTMG_T_RFC_MIN                \ T_RFC_MIN
$00008000 constant DDRCTRL_DDRCTRL_RFSHTMG_LPDDR3_TREFBW_EN         \ LPDDR3_TREFBW_EN
$0fff0000 constant DDRCTRL_DDRCTRL_RFSHTMG_T_RFC_NOM_X1_X32         \ T_RFC_NOM_X1_X32
$80000000 constant DDRCTRL_DDRCTRL_RFSHTMG_T_RFC_NOM_X1_SEL         \ T_RFC_NOM_X1_SEL


\
\ @brief DDRCTRL CRC parity control register 0
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000001 constant DDRCTRL_DDRCTRL_CRCPARCTL0_DFI_ALERT_ERR_INT_EN    \ DFI_ALERT_ERR_INT_EN
$00000002 constant DDRCTRL_DDRCTRL_CRCPARCTL0_DFI_ALERT_ERR_INT_CLR    \ DFI_ALERT_ERR_INT_CLR
$00000004 constant DDRCTRL_DDRCTRL_CRCPARCTL0_DFI_ALERT_ERR_CNT_CLR    \ DFI_ALERT_ERR_CNT_CLR


\
\ @brief DDRCTRL CRC parity status register
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$0000ffff constant DDRCTRL_DDRCTRL_CRCPARSTAT_DFI_ALERT_ERR_CNT     \ DFI_ALERT_ERR_CNT
$00010000 constant DDRCTRL_DDRCTRL_CRCPARSTAT_DFI_ALERT_ERR_INT     \ DFI_ALERT_ERR_INT


\
\ @brief DDRCTRL SDRAM initialization register 0
\ Address offset: 0xD0
\ Reset value: 0x0002004E
\

$00000fff constant DDRCTRL_DDRCTRL_INIT0_PRE_CKE_X1024              \ PRE_CKE_X1024
$03ff0000 constant DDRCTRL_DDRCTRL_INIT0_POST_CKE_X1024             \ POST_CKE_X1024
$c0000000 constant DDRCTRL_DDRCTRL_INIT0_SKIP_DRAM_INIT             \ SKIP_DRAM_INIT


\
\ @brief DDRCTRL SDRAM initialization register 1
\ Address offset: 0xD4
\ Reset value: 0x00000000
\

$0000000f constant DDRCTRL_DDRCTRL_INIT1_PRE_OCD_X32                \ PRE_OCD_X32
$01ff0000 constant DDRCTRL_DDRCTRL_INIT1_DRAM_RSTN_X1024            \ DRAM_RSTN_X1024


\
\ @brief DDRCTRL SDRAM initialization register 2
\ Address offset: 0xD8
\ Reset value: 0x00000D05
\

$0000000f constant DDRCTRL_DDRCTRL_INIT2_MIN_STABLE_CLOCK_X1        \ MIN_STABLE_CLOCK_X1
$0000ff00 constant DDRCTRL_DDRCTRL_INIT2_IDLE_AFTER_RESET_X32       \ IDLE_AFTER_RESET_X32


\
\ @brief DDRCTRL SDRAM initialization register 3
\ Address offset: 0xDC
\ Reset value: 0x00000510
\

$0000ffff constant DDRCTRL_DDRCTRL_INIT3_EMR                        \ EMR
$ffff0000 constant DDRCTRL_DDRCTRL_INIT3_MR                         \ MR


\
\ @brief DDRCTRL SDRAM initialization register 4
\ Address offset: 0xE0
\ Reset value: 0x00000000
\

$0000ffff constant DDRCTRL_DDRCTRL_INIT4_EMR3                       \ EMR3
$ffff0000 constant DDRCTRL_DDRCTRL_INIT4_EMR2                       \ EMR2


\
\ @brief DDRCTRL SDRAM initialization register 5
\ Address offset: 0xE4
\ Reset value: 0x00100004
\

$000003ff constant DDRCTRL_DDRCTRL_INIT5_MAX_AUTO_INIT_X1024        \ MAX_AUTO_INIT_X1024
$00ff0000 constant DDRCTRL_DDRCTRL_INIT5_DEV_ZQINIT_X32             \ DEV_ZQINIT_X32


\
\ @brief DDRCTRL DIMM control register
\ Address offset: 0xF0
\ Reset value: 0x00000000
\

$00000001 constant DDRCTRL_DDRCTRL_DIMMCTL_DIMM_STAGGER_CS_EN       \ DIMM_STAGGER_CS_EN
$00000002 constant DDRCTRL_DDRCTRL_DIMMCTL_DIMM_ADDR_MIRR_EN        \ DIMM_ADDR_MIRR_EN


\
\ @brief DDRCTRL SDRAM timing register 0
\ Address offset: 0x100
\ Reset value: 0x0F101B0F
\

$0000003f constant DDRCTRL_DDRCTRL_DRAMTMG0_T_RAS_MIN               \ T_RAS_MIN
$00007f00 constant DDRCTRL_DDRCTRL_DRAMTMG0_T_RAS_MAX               \ T_RAS_MAX
$003f0000 constant DDRCTRL_DDRCTRL_DRAMTMG0_T_FAW                   \ T_FAW
$7f000000 constant DDRCTRL_DDRCTRL_DRAMTMG0_WR2PRE                  \ WR2PRE


\
\ @brief DDRCTRL SDRAM timing register 1
\ Address offset: 0x104
\ Reset value: 0x00080414
\

$0000007f constant DDRCTRL_DDRCTRL_DRAMTMG1_T_RC                    \ T_RC
$00003f00 constant DDRCTRL_DDRCTRL_DRAMTMG1_RD2PRE                  \ RD2PRE
$001f0000 constant DDRCTRL_DDRCTRL_DRAMTMG1_T_XP                    \ T_XP


\
\ @brief DDRCTRL SDRAM timing register 2
\ Address offset: 0x108
\ Reset value: 0x0305060D
\

$0000003f constant DDRCTRL_DDRCTRL_DRAMTMG2_WR2RD                   \ WR2RD
$00003f00 constant DDRCTRL_DDRCTRL_DRAMTMG2_RD2WR                   \ RD2WR
$003f0000 constant DDRCTRL_DDRCTRL_DRAMTMG2_READ_LATENCY            \ READ_LATENCY
$3f000000 constant DDRCTRL_DDRCTRL_DRAMTMG2_WRITE_LATENCY           \ WRITE_LATENCY


\
\ @brief DDRCTRL SDRAM timing register 3
\ Address offset: 0x10C
\ Reset value: 0x0050400C
\

$000003ff constant DDRCTRL_DDRCTRL_DRAMTMG3_T_MOD                   \ T_MOD
$0003f000 constant DDRCTRL_DDRCTRL_DRAMTMG3_T_MRD                   \ T_MRD
$3ff00000 constant DDRCTRL_DDRCTRL_DRAMTMG3_T_MRW                   \ T_MRW


\
\ @brief DDRCTRL SDRAM timing register 4
\ Address offset: 0x110
\ Reset value: 0x05040405
\

$0000001f constant DDRCTRL_DDRCTRL_DRAMTMG4_T_RP                    \ T_RP
$00000f00 constant DDRCTRL_DDRCTRL_DRAMTMG4_T_RRD                   \ T_RRD
$000f0000 constant DDRCTRL_DDRCTRL_DRAMTMG4_T_CCD                   \ T_CCD
$1f000000 constant DDRCTRL_DDRCTRL_DRAMTMG4_T_RCD                   \ T_RCD


\
\ @brief DDRCTRL SDRAM timing register 5
\ Address offset: 0x114
\ Reset value: 0x05050403
\

$0000001f constant DDRCTRL_DDRCTRL_DRAMTMG5_T_CKE                   \ T_CKE
$00003f00 constant DDRCTRL_DDRCTRL_DRAMTMG5_T_CKESR                 \ T_CKESR
$000f0000 constant DDRCTRL_DDRCTRL_DRAMTMG5_T_CKSRE                 \ T_CKSRE
$0f000000 constant DDRCTRL_DDRCTRL_DRAMTMG5_T_CKSRX                 \ T_CKSRX


\
\ @brief DDRCTRL SDRAM timing register 6
\ Address offset: 0x118
\ Reset value: 0x02020005
\

$0000000f constant DDRCTRL_DDRCTRL_DRAMTMG6_T_CKCSX                 \ T_CKCSX
$000f0000 constant DDRCTRL_DDRCTRL_DRAMTMG6_T_CKDPDX                \ T_CKDPDX
$0f000000 constant DDRCTRL_DDRCTRL_DRAMTMG6_T_CKDPDE                \ T_CKDPDE


\
\ @brief DDRCTRL SDRAM timing register 7
\ Address offset: 0x11C
\ Reset value: 0x00000202
\

$0000000f constant DDRCTRL_DDRCTRL_DRAMTMG7_T_CKPDX                 \ T_CKPDX
$00000f00 constant DDRCTRL_DDRCTRL_DRAMTMG7_T_CKPDE                 \ T_CKPDE


\
\ @brief DDRCTRL SDRAM timing register 8
\ Address offset: 0x120
\ Reset value: 0x00004405
\

$0000007f constant DDRCTRL_DDRCTRL_DRAMTMG8_T_XS_X32                \ T_XS_X32
$00007f00 constant DDRCTRL_DDRCTRL_DRAMTMG8_T_XS_DLL_X32            \ T_XS_DLL_X32


\
\ @brief DDRCTRL SDRAM timing register 14
\ Address offset: 0x138
\ Reset value: 0x000000A0
\

$00000fff constant DDRCTRL_DDRCTRL_DRAMTMG14_T_XSR                  \ T_XSR


\
\ @brief DDRCTRL SDRAM timing register 15
\ Address offset: 0x13C
\ Reset value: 0x00000000
\

$000000ff constant DDRCTRL_DDRCTRL_DRAMTMG15_T_STAB_X32             \ T_STAB_X32
$80000000 constant DDRCTRL_DDRCTRL_DRAMTMG15_EN_DFI_LP_T_STAB       \ EN_DFI_LP_T_STAB


\
\ @brief DDRCTRL ZQ control register 0
\ Address offset: 0x180
\ Reset value: 0x02000040
\

$000003ff constant DDRCTRL_DDRCTRL_ZQCTL0_T_ZQ_SHORT_NOP            \ T_ZQ_SHORT_NOP
$07ff0000 constant DDRCTRL_DDRCTRL_ZQCTL0_T_ZQ_LONG_NOP             \ T_ZQ_LONG_NOP
$20000000 constant DDRCTRL_DDRCTRL_ZQCTL0_ZQ_RESISTOR_SHARED        \ ZQ_RESISTOR_SHARED
$40000000 constant DDRCTRL_DDRCTRL_ZQCTL0_DIS_SRX_ZQCL              \ DIS_SRX_ZQCL
$80000000 constant DDRCTRL_DDRCTRL_ZQCTL0_DIS_AUTO_ZQ               \ DIS_AUTO_ZQ


\
\ @brief DDRCTRL ZQ control register 1
\ Address offset: 0x184
\ Reset value: 0x02000100
\

$000fffff constant DDRCTRL_DDRCTRL_ZQCTL1_T_ZQ_SHORT_INTERVAL_X1024    \ T_ZQ_SHORT_INTERVAL_X1024
$3ff00000 constant DDRCTRL_DDRCTRL_ZQCTL1_T_ZQ_RESET_NOP            \ T_ZQ_RESET_NOP


\
\ @brief DDRCTRL ZQ control register 2
\ Address offset: 0x188
\ Reset value: 0x00000000
\

$00000001 constant DDRCTRL_DDRCTRL_ZQCTL2_ZQ_RESET                  \ ZQ_RESET


\
\ @brief DDRCTRL ZQ status register
\ Address offset: 0x18C
\ Reset value: 0x00000000
\

$00000001 constant DDRCTRL_DDRCTRL_ZQSTAT_ZQ_RESET_BUSY             \ ZQ_RESET_BUSY


\
\ @brief DDRCTRL DFI timing register 0
\ Address offset: 0x190
\ Reset value: 0x07020002
\

$0000003f constant DDRCTRL_DDRCTRL_DFITMG0_DFI_TPHY_WRLAT           \ DFI_TPHY_WRLAT
$00003f00 constant DDRCTRL_DDRCTRL_DFITMG0_DFI_TPHY_WRDATA          \ DFI_TPHY_WRDATA
$007f0000 constant DDRCTRL_DDRCTRL_DFITMG0_DFI_T_RDDATA_EN          \ DFI_T_RDDATA_EN
$1f000000 constant DDRCTRL_DDRCTRL_DFITMG0_DFI_T_CTRL_DELAY         \ DFI_T_CTRL_DELAY


\
\ @brief DDRCTRL DFI timing register 1
\ Address offset: 0x194
\ Reset value: 0x00000404
\

$0000001f constant DDRCTRL_DDRCTRL_DFITMG1_DFI_T_DRAM_CLK_ENABLE    \ DFI_T_DRAM_CLK_ENABLE
$00001f00 constant DDRCTRL_DDRCTRL_DFITMG1_DFI_T_DRAM_CLK_DISABLE    \ DFI_T_DRAM_CLK_DISABLE
$001f0000 constant DDRCTRL_DDRCTRL_DFITMG1_DFI_T_WRDATA_DELAY       \ DFI_T_WRDATA_DELAY


\
\ @brief DDRCTRL low power configuration register 0
\ Address offset: 0x198
\ Reset value: 0x07000000
\

$00000001 constant DDRCTRL_DDRCTRL_DFILPCFG0_DFI_LP_EN_PD           \ DFI_LP_EN_PD
$000000f0 constant DDRCTRL_DDRCTRL_DFILPCFG0_DFI_LP_WAKEUP_PD       \ DFI_LP_WAKEUP_PD
$00000100 constant DDRCTRL_DDRCTRL_DFILPCFG0_DFI_LP_EN_SR           \ DFI_LP_EN_SR
$0000f000 constant DDRCTRL_DDRCTRL_DFILPCFG0_DFI_LP_WAKEUP_SR       \ DFI_LP_WAKEUP_SR
$00010000 constant DDRCTRL_DDRCTRL_DFILPCFG0_DFI_LP_EN_DPD          \ DFI_LP_EN_DPD
$00f00000 constant DDRCTRL_DDRCTRL_DFILPCFG0_DFI_LP_WAKEUP_DPD      \ DFI_LP_WAKEUP_DPD
$1f000000 constant DDRCTRL_DDRCTRL_DFILPCFG0_DFI_TLP_RESP           \ DFI_TLP_RESP


\
\ @brief DDRCTRL DFI update register 0
\ Address offset: 0x1A0
\ Reset value: 0x00400003
\

$000003ff constant DDRCTRL_DDRCTRL_DFIUPD0_DFI_T_CTRLUP_MIN         \ DFI_T_CTRLUP_MIN
$03ff0000 constant DDRCTRL_DDRCTRL_DFIUPD0_DFI_T_CTRLUP_MAX         \ DFI_T_CTRLUP_MAX
$20000000 constant DDRCTRL_DDRCTRL_DFIUPD0_CTRLUPD_PRE_SRX          \ CTRLUPD_PRE_SRX
$40000000 constant DDRCTRL_DDRCTRL_DFIUPD0_DIS_AUTO_CTRLUPD_SRX     \ DIS_AUTO_CTRLUPD_SRX
$80000000 constant DDRCTRL_DDRCTRL_DFIUPD0_DIS_AUTO_CTRLUPD         \ DIS_AUTO_CTRLUPD


\
\ @brief DDRCTRL DFI update register 1
\ Address offset: 0x1A4
\ Reset value: 0x00010001
\

$000000ff constant DDRCTRL_DDRCTRL_DFIUPD1_DFI_T_CTRLUPD_INTERVAL_MAX_X1024    \ DFI_T_CTRLUPD_INTERVAL_MAX_X1024
$00ff0000 constant DDRCTRL_DDRCTRL_DFIUPD1_DFI_T_CTRLUPD_INTERVAL_MIN_X1024    \ DFI_T_CTRLUPD_INTERVAL_MIN_X1024


\
\ @brief DDRCTRL DFI update register 2
\ Address offset: 0x1A8
\ Reset value: 0x80000000
\

$80000000 constant DDRCTRL_DDRCTRL_DFIUPD2_DFI_PHYUPD_EN            \ DFI_PHYUPD_EN


\
\ @brief DDRCTRL DFI miscellaneous control register
\ Address offset: 0x1B0
\ Reset value: 0x00000001
\

$00000001 constant DDRCTRL_DDRCTRL_DFIMISC_DFI_INIT_COMPLETE_EN     \ DFI_INIT_COMPLETE_EN
$00000010 constant DDRCTRL_DDRCTRL_DFIMISC_CTL_IDLE_EN              \ CTL_IDLE_EN
$00000020 constant DDRCTRL_DDRCTRL_DFIMISC_DFI_INIT_START           \ DFI_INIT_START
$00001f00 constant DDRCTRL_DDRCTRL_DFIMISC_DFI_FREQUENCY            \ DFI_FREQUENCY


\
\ @brief DDRCTRL DFI status register
\ Address offset: 0x1BC
\ Reset value: 0x00000000
\

$00000001 constant DDRCTRL_DDRCTRL_DFISTAT_DFI_INIT_COMPLETE        \ DFI_INIT_COMPLETE
$00000002 constant DDRCTRL_DDRCTRL_DFISTAT_DFI_LP_ACK               \ DFI_LP_ACK


\
\ @brief DDRCTRL DFI PHY master register
\ Address offset: 0x1C4
\ Reset value: 0x00000001
\

$00000001 constant DDRCTRL_DDRCTRL_DFIPHYMSTR_DFI_PHYMSTR_EN        \ DFI_PHYMSTR_EN


\
\ @brief DDRCTRL address map register 1
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$0000003f constant DDRCTRL_DDRCTRL_ADDRMAP1_ADDRMAP_BANK_B0         \ ADDRMAP_BANK_B0
$00003f00 constant DDRCTRL_DDRCTRL_ADDRMAP1_ADDRMAP_BANK_B1         \ ADDRMAP_BANK_B1
$003f0000 constant DDRCTRL_DDRCTRL_ADDRMAP1_ADDRMAP_BANK_B2         \ ADDRMAP_BANK_B2


\
\ @brief DDRCTRL address map register 2
\ Address offset: 0x208
\ Reset value: 0x00000000
\

$0000000f constant DDRCTRL_DDRCTRL_ADDRMAP2_ADDRMAP_COL_B2          \ ADDRMAP_COL_B2
$00000f00 constant DDRCTRL_DDRCTRL_ADDRMAP2_ADDRMAP_COL_B3          \ ADDRMAP_COL_B3
$000f0000 constant DDRCTRL_DDRCTRL_ADDRMAP2_ADDRMAP_COL_B4          \ ADDRMAP_COL_B4
$0f000000 constant DDRCTRL_DDRCTRL_ADDRMAP2_ADDRMAP_COL_B5          \ ADDRMAP_COL_B5


\
\ @brief DDRCTRL address map register 3
\ Address offset: 0x20C
\ Reset value: 0x00000000
\

$0000000f constant DDRCTRL_DDRCTRL_ADDRMAP3_ADDRMAP_COL_B6          \ ADDRMAP_COL_B6
$00001f00 constant DDRCTRL_DDRCTRL_ADDRMAP3_ADDRMAP_COL_B7          \ ADDRMAP_COL_B7
$001f0000 constant DDRCTRL_DDRCTRL_ADDRMAP3_ADDRMAP_COL_B8          \ ADDRMAP_COL_B8
$1f000000 constant DDRCTRL_DDRCTRL_ADDRMAP3_ADDRMAP_COL_B9          \ ADDRMAP_COL_B9


\
\ @brief DDRCTRL address map register 4
\ Address offset: 0x210
\ Reset value: 0x00000000
\

$0000001f constant DDRCTRL_DDRCTRL_ADDRMAP4_ADDRMAP_COL_B10         \ ADDRMAP_COL_B10
$00001f00 constant DDRCTRL_DDRCTRL_ADDRMAP4_ADDRMAP_COL_B11         \ ADDRMAP_COL_B11


\
\ @brief DDRCTRL address map register 5
\ Address offset: 0x214
\ Reset value: 0x00000000
\

$0000000f constant DDRCTRL_DDRCTRL_ADDRMAP5_ADDRMAP_ROW_B0          \ ADDRMAP_ROW_B0
$00000f00 constant DDRCTRL_DDRCTRL_ADDRMAP5_ADDRMAP_ROW_B1          \ ADDRMAP_ROW_B1
$000f0000 constant DDRCTRL_DDRCTRL_ADDRMAP5_ADDRMAP_ROW_B2_10       \ ADDRMAP_ROW_B2_10
$0f000000 constant DDRCTRL_DDRCTRL_ADDRMAP5_ADDRMAP_ROW_B11         \ ADDRMAP_ROW_B11


\
\ @brief DDRCTRL address register 6
\ Address offset: 0x218
\ Reset value: 0x00000000
\

$0000000f constant DDRCTRL_DDRCTRL_ADDRMAP6_ADDRMAP_ROW_B12         \ ADDRMAP_ROW_B12
$00000f00 constant DDRCTRL_DDRCTRL_ADDRMAP6_ADDRMAP_ROW_B13         \ ADDRMAP_ROW_B13
$000f0000 constant DDRCTRL_DDRCTRL_ADDRMAP6_ADDRMAP_ROW_B14         \ ADDRMAP_ROW_B14
$0f000000 constant DDRCTRL_DDRCTRL_ADDRMAP6_ADDRMAP_ROW_B15         \ ADDRMAP_ROW_B15
$80000000 constant DDRCTRL_DDRCTRL_ADDRMAP6_LPDDR3_6GB_12GB         \ LPDDR3_6GB_12GB


\
\ @brief DDRCTRL address map register 9
\ Address offset: 0x224
\ Reset value: 0x00000000
\

$0000000f constant DDRCTRL_DDRCTRL_ADDRMAP9_ADDRMAP_ROW_B2          \ ADDRMAP_ROW_B2
$00000f00 constant DDRCTRL_DDRCTRL_ADDRMAP9_ADDRMAP_ROW_B3          \ ADDRMAP_ROW_B3
$000f0000 constant DDRCTRL_DDRCTRL_ADDRMAP9_ADDRMAP_ROW_B4          \ ADDRMAP_ROW_B4
$0f000000 constant DDRCTRL_DDRCTRL_ADDRMAP9_ADDRMAP_ROW_B5          \ ADDRMAP_ROW_B5


\
\ @brief DDRCTRL address map register 10
\ Address offset: 0x228
\ Reset value: 0x00000000
\

$0000000f constant DDRCTRL_DDRCTRL_ADDRMAP10_ADDRMAP_ROW_B6         \ ADDRMAP_ROW_B6
$00000f00 constant DDRCTRL_DDRCTRL_ADDRMAP10_ADDRMAP_ROW_B7         \ ADDRMAP_ROW_B7
$000f0000 constant DDRCTRL_DDRCTRL_ADDRMAP10_ADDRMAP_ROW_B8         \ ADDRMAP_ROW_B8
$0f000000 constant DDRCTRL_DDRCTRL_ADDRMAP10_ADDRMAP_ROW_B9         \ ADDRMAP_ROW_B9


\
\ @brief DDRCTRL address map register 11
\ Address offset: 0x22C
\ Reset value: 0x00000000
\

$0000000f constant DDRCTRL_DDRCTRL_ADDRMAP11_ADDRMAP_ROW_B10        \ ADDRMAP_ROW_B10


\
\ @brief DDRCTRL ODT configuration register
\ Address offset: 0x240
\ Reset value: 0x04000400
\

$0000007c constant DDRCTRL_DDRCTRL_ODTCFG_RD_ODT_DELAY              \ RD_ODT_DELAY
$00000f00 constant DDRCTRL_DDRCTRL_ODTCFG_RD_ODT_HOLD               \ RD_ODT_HOLD
$001f0000 constant DDRCTRL_DDRCTRL_ODTCFG_WR_ODT_DELAY              \ WR_ODT_DELAY
$0f000000 constant DDRCTRL_DDRCTRL_ODTCFG_WR_ODT_HOLD               \ WR_ODT_HOLD


\
\ @brief DDRCTRL ODT/Rank map register
\ Address offset: 0x244
\ Reset value: 0x00000011
\

$00000001 constant DDRCTRL_DDRCTRL_ODTMAP_RANK0_WR_ODT              \ RANK0_WR_ODT
$00000010 constant DDRCTRL_DDRCTRL_ODTMAP_RANK0_RD_ODT              \ RANK0_RD_ODT


\
\ @brief DDRCTRL scheduler control register
\ Address offset: 0x250
\ Reset value: 0x00000805
\

$00000001 constant DDRCTRL_DDRCTRL_SCHED_FORCE_LOW_PRI_N            \ FORCE_LOW_PRI_N
$00000002 constant DDRCTRL_DDRCTRL_SCHED_PREFER_WRITE               \ PREFER_WRITE
$00000004 constant DDRCTRL_DDRCTRL_SCHED_PAGECLOSE                  \ PAGECLOSE
$00000f00 constant DDRCTRL_DDRCTRL_SCHED_LPR_NUM_ENTRIES            \ LPR_NUM_ENTRIES
$00ff0000 constant DDRCTRL_DDRCTRL_SCHED_GO2CRITICAL_HYSTERESIS     \ GO2CRITICAL_HYSTERESIS
$7f000000 constant DDRCTRL_DDRCTRL_SCHED_RDWR_IDLE_GAP              \ RDWR_IDLE_GAP


\
\ @brief DDRCTRL scheduler control register 1
\ Address offset: 0x254
\ Reset value: 0x00000000
\

$000000ff constant DDRCTRL_DDRCTRL_SCHED1_PAGECLOSE_TIMER           \ PAGECLOSE_TIMER


\
\ @brief DDRCTRL high priority read CAM register 1
\ Address offset: 0x25C
\ Reset value: 0x0F000001
\

$0000ffff constant DDRCTRL_DDRCTRL_PERFHPR1_HPR_MAX_STARVE          \ HPR_MAX_STARVE
$ff000000 constant DDRCTRL_DDRCTRL_PERFHPR1_HPR_XACT_RUN_LENGTH     \ HPR_XACT_RUN_LENGTH


\
\ @brief DDRCTRL low priority read CAM register 1
\ Address offset: 0x264
\ Reset value: 0x0F00007F
\

$0000ffff constant DDRCTRL_DDRCTRL_PERFLPR1_LPR_MAX_STARVE          \ LPR_MAX_STARVE
$ff000000 constant DDRCTRL_DDRCTRL_PERFLPR1_LPR_XACT_RUN_LENGTH     \ LPR_XACT_RUN_LENGTH


\
\ @brief DDRCTRL write CAM register 1
\ Address offset: 0x26C
\ Reset value: 0x0F00007F
\

$0000ffff constant DDRCTRL_DDRCTRL_PERFWR1_W_MAX_STARVE             \ W_MAX_STARVE
$ff000000 constant DDRCTRL_DDRCTRL_PERFWR1_W_XACT_RUN_LENGTH        \ W_XACT_RUN_LENGTH


\
\ @brief DDRCTRL debug register 0
\ Address offset: 0x300
\ Reset value: 0x00000000
\

$00000001 constant DDRCTRL_DDRCTRL_DBG0_DIS_WC                      \ DIS_WC
$00000010 constant DDRCTRL_DDRCTRL_DBG0_DIS_COLLISION_PAGE_OPT      \ DIS_COLLISION_PAGE_OPT


\
\ @brief DDRCTRL debug register 1
\ Address offset: 0x304
\ Reset value: 0x00000000
\

$00000001 constant DDRCTRL_DDRCTRL_DBG1_DIS_DQ                      \ DIS_DQ
$00000002 constant DDRCTRL_DDRCTRL_DBG1_DIS_HIF                     \ DIS_HIF


\
\ @brief DDRCTRL CAM debug register
\ Address offset: 0x308
\ Reset value: 0x00000000
\

$0000001f constant DDRCTRL_DDRCTRL_DBGCAM_DBG_HPR_Q_DEPTH           \ DBG_HPR_Q_DEPTH
$00001f00 constant DDRCTRL_DDRCTRL_DBGCAM_DBG_LPR_Q_DEPTH           \ DBG_LPR_Q_DEPTH
$001f0000 constant DDRCTRL_DDRCTRL_DBGCAM_DBG_W_Q_DEPTH             \ DBG_W_Q_DEPTH
$01000000 constant DDRCTRL_DDRCTRL_DBGCAM_DBG_STALL                 \ DBG_STALL
$02000000 constant DDRCTRL_DDRCTRL_DBGCAM_DBG_RD_Q_EMPTY            \ DBG_RD_Q_EMPTY
$04000000 constant DDRCTRL_DDRCTRL_DBGCAM_DBG_WR_Q_EMPTY            \ DBG_WR_Q_EMPTY
$10000000 constant DDRCTRL_DDRCTRL_DBGCAM_RD_DATA_PIPELINE_EMPTY    \ RD_DATA_PIPELINE_EMPTY
$20000000 constant DDRCTRL_DDRCTRL_DBGCAM_WR_DATA_PIPELINE_EMPTY    \ WR_DATA_PIPELINE_EMPTY


\
\ @brief DDRCTRL command debug register
\ Address offset: 0x30C
\ Reset value: 0x00000000
\

$00000001 constant DDRCTRL_DDRCTRL_DBGCMD_RANK0_REFRESH             \ RANK0_REFRESH
$00000010 constant DDRCTRL_DDRCTRL_DBGCMD_ZQ_CALIB_SHORT            \ ZQ_CALIB_SHORT
$00000020 constant DDRCTRL_DDRCTRL_DBGCMD_CTRLUPD                   \ CTRLUPD


\
\ @brief DDRCTRL status debug register
\ Address offset: 0x310
\ Reset value: 0x00000000
\

$00000001 constant DDRCTRL_DDRCTRL_DBGSTAT_RANK0_REFRESH_BUSY       \ RANK0_REFRESH_BUSY
$00000010 constant DDRCTRL_DDRCTRL_DBGSTAT_ZQ_CALIB_SHORT_BUSY      \ ZQ_CALIB_SHORT_BUSY
$00000020 constant DDRCTRL_DDRCTRL_DBGSTAT_CTRLUPD_BUSY             \ CTRLUPD_BUSY


\
\ @brief DDRCTRL software register programming control enable
\ Address offset: 0x320
\ Reset value: 0x00000001
\

$00000001 constant DDRCTRL_DDRCTRL_SWCTL_SW_DONE                    \ SW_DONE


\
\ @brief DDRCTRL software register programming control status
\ Address offset: 0x324
\ Reset value: 0x00000001
\

$00000001 constant DDRCTRL_DDRCTRL_SWSTAT_SW_DONE_ACK               \ SW_DONE_ACK


\
\ @brief AXI Poison configuration register common for all AXI ports.
\ Address offset: 0x36C
\ Reset value: 0x00110011
\

$00000001 constant DDRCTRL_DDRCTRL_POISONCFG_WR_POISON_SLVERR_EN    \ WR_POISON_SLVERR_EN
$00000010 constant DDRCTRL_DDRCTRL_POISONCFG_WR_POISON_INTR_EN      \ WR_POISON_INTR_EN
$00000100 constant DDRCTRL_DDRCTRL_POISONCFG_WR_POISON_INTR_CLR     \ WR_POISON_INTR_CLR
$00010000 constant DDRCTRL_DDRCTRL_POISONCFG_RD_POISON_SLVERR_EN    \ RD_POISON_SLVERR_EN
$00100000 constant DDRCTRL_DDRCTRL_POISONCFG_RD_POISON_INTR_EN      \ RD_POISON_INTR_EN
$01000000 constant DDRCTRL_DDRCTRL_POISONCFG_RD_POISON_INTR_CLR     \ RD_POISON_INTR_CLR


\
\ @brief DDRCTRL AXI Poison status register
\ Address offset: 0x370
\ Reset value: 0x00000000
\

$00000001 constant DDRCTRL_DDRCTRL_POISONSTAT_WR_POISON_INTR_0      \ WR_POISON_INTR_0
$00000002 constant DDRCTRL_DDRCTRL_POISONSTAT_WR_POISON_INTR_1      \ WR_POISON_INTR_1
$00010000 constant DDRCTRL_DDRCTRL_POISONSTAT_RD_POISON_INTR_0      \ RD_POISON_INTR_0
$00020000 constant DDRCTRL_DDRCTRL_POISONSTAT_RD_POISON_INTR_1      \ RD_POISON_INTR_1


\
\ @brief DDRCTRL port status register
\ Address offset: 0x3FC
\ Reset value: 0x00000000
\

$00000001 constant DDRCTRL_DDRCTRL_PSTAT_RD_PORT_BUSY_0             \ RD_PORT_BUSY_0
$00000002 constant DDRCTRL_DDRCTRL_PSTAT_RD_PORT_BUSY_1             \ RD_PORT_BUSY_1
$00010000 constant DDRCTRL_DDRCTRL_PSTAT_WR_PORT_BUSY_0             \ WR_PORT_BUSY_0
$00020000 constant DDRCTRL_DDRCTRL_PSTAT_WR_PORT_BUSY_1             \ WR_PORT_BUSY_1


\
\ @brief DDRCTRL port common configuration register
\ Address offset: 0x400
\ Reset value: 0x00000000
\

$00000001 constant DDRCTRL_DDRCTRL_PCCFG_GO2CRITICAL_EN             \ GO2CRITICAL_EN
$00000010 constant DDRCTRL_DDRCTRL_PCCFG_PAGEMATCH_LIMIT            \ PAGEMATCH_LIMIT
$00000100 constant DDRCTRL_DDRCTRL_PCCFG_BL_EXP_MODE                \ BL_EXP_MODE


\
\ @brief DDRCTRL port 0 configuration read register
\ Address offset: 0x404
\ Reset value: 0x00004000
\

$000003ff constant DDRCTRL_DDRCTRL_PCFGR_0_RD_PORT_PRIORITY         \ RD_PORT_PRIORITY
$00001000 constant DDRCTRL_DDRCTRL_PCFGR_0_RD_PORT_AGING_EN         \ RD_PORT_AGING_EN
$00002000 constant DDRCTRL_DDRCTRL_PCFGR_0_RD_PORT_URGENT_EN        \ RD_PORT_URGENT_EN
$00004000 constant DDRCTRL_DDRCTRL_PCFGR_0_RD_PORT_PAGEMATCH_EN     \ RD_PORT_PAGEMATCH_EN
$00010000 constant DDRCTRL_DDRCTRL_PCFGR_0_RDWR_ORDERED_EN          \ RDWR_ORDERED_EN


\
\ @brief DDRCTRL port 0 configuration write register
\ Address offset: 0x408
\ Reset value: 0x00004000
\

$000003ff constant DDRCTRL_DDRCTRL_PCFGW_0_WR_PORT_PRIORITY         \ WR_PORT_PRIORITY
$00001000 constant DDRCTRL_DDRCTRL_PCFGW_0_WR_PORT_AGING_EN         \ WR_PORT_AGING_EN
$00002000 constant DDRCTRL_DDRCTRL_PCFGW_0_WR_PORT_URGENT_EN        \ WR_PORT_URGENT_EN
$00004000 constant DDRCTRL_DDRCTRL_PCFGW_0_WR_PORT_PAGEMATCH_EN     \ WR_PORT_PAGEMATCH_EN


\
\ @brief DDRCTRL port 0 control register
\ Address offset: 0x490
\ Reset value: 0x00000000
\

$00000001 constant DDRCTRL_DDRCTRL_PCTRL_0_PORT_EN                  \ PORT_EN


\
\ @brief DDRCTRL port 0 read Q0S configuration register 0
\ Address offset: 0x494
\ Reset value: 0x02000E00
\

$0000000f constant DDRCTRL_DDRCTRL_PCFGQOS0_0_RQOS_MAP_LEVEL1       \ RQOS_MAP_LEVEL1
$00000f00 constant DDRCTRL_DDRCTRL_PCFGQOS0_0_RQOS_MAP_LEVEL2       \ RQOS_MAP_LEVEL2
$00030000 constant DDRCTRL_DDRCTRL_PCFGQOS0_0_RQOS_MAP_REGION0      \ RQOS_MAP_REGION0
$00300000 constant DDRCTRL_DDRCTRL_PCFGQOS0_0_RQOS_MAP_REGION1      \ RQOS_MAP_REGION1
$03000000 constant DDRCTRL_DDRCTRL_PCFGQOS0_0_RQOS_MAP_REGION2      \ RQOS_MAP_REGION2


\
\ @brief DDRCTRL port 0 read Q0S configuration register 1
\ Address offset: 0x498
\ Reset value: 0x00000000
\

$000007ff constant DDRCTRL_DDRCTRL_PCFGQOS1_0_RQOS_MAP_TIMEOUTB     \ RQOS_MAP_TIMEOUTB
$07ff0000 constant DDRCTRL_DDRCTRL_PCFGQOS1_0_RQOS_MAP_TIMEOUTR     \ RQOS_MAP_TIMEOUTR


\
\ @brief DDRCTRL port 0 write Q0S configuration register 0
\ Address offset: 0x49C
\ Reset value: 0x00000E00
\

$0000000f constant DDRCTRL_DDRCTRL_PCFGWQOS0_0_WQOS_MAP_LEVEL1      \ WQOS_MAP_LEVEL1
$00000f00 constant DDRCTRL_DDRCTRL_PCFGWQOS0_0_WQOS_MAP_LEVEL2      \ WQOS_MAP_LEVEL2
$00030000 constant DDRCTRL_DDRCTRL_PCFGWQOS0_0_WQOS_MAP_REGION0     \ WQOS_MAP_REGION0
$00300000 constant DDRCTRL_DDRCTRL_PCFGWQOS0_0_WQOS_MAP_REGION1     \ WQOS_MAP_REGION1
$03000000 constant DDRCTRL_DDRCTRL_PCFGWQOS0_0_WQOS_MAP_REGION2     \ WQOS_MAP_REGION2


\
\ @brief DDRCTRL port 0 write Q0S configuration register 1
\ Address offset: 0x4A0
\ Reset value: 0x00000000
\

$000007ff constant DDRCTRL_DDRCTRL_PCFGWQOS1_0_WQOS_MAP_TIMEOUT1    \ WQOS_MAP_TIMEOUT1
$07ff0000 constant DDRCTRL_DDRCTRL_PCFGWQOS1_0_WQOS_MAP_TIMEOUT2    \ WQOS_MAP_TIMEOUT2


\
\ @brief DDRCTRL port 1 configuration read register
\ Address offset: 0x4B4
\ Reset value: 0x00004000
\

$000003ff constant DDRCTRL_DDRCTRL_PCFGR_1_RD_PORT_PRIORITY         \ RD_PORT_PRIORITY
$00001000 constant DDRCTRL_DDRCTRL_PCFGR_1_RD_PORT_AGING_EN         \ RD_PORT_AGING_EN
$00002000 constant DDRCTRL_DDRCTRL_PCFGR_1_RD_PORT_URGENT_EN        \ RD_PORT_URGENT_EN
$00004000 constant DDRCTRL_DDRCTRL_PCFGR_1_RD_PORT_PAGEMATCH_EN     \ RD_PORT_PAGEMATCH_EN
$00010000 constant DDRCTRL_DDRCTRL_PCFGR_1_RDWR_ORDERED_EN          \ RDWR_ORDERED_EN


\
\ @brief DDRCTRL port 1 configuration write register
\ Address offset: 0x4B8
\ Reset value: 0x00004000
\

$000003ff constant DDRCTRL_DDRCTRL_PCFGW_1_WR_PORT_PRIORITY         \ WR_PORT_PRIORITY
$00001000 constant DDRCTRL_DDRCTRL_PCFGW_1_WR_PORT_AGING_EN         \ WR_PORT_AGING_EN
$00002000 constant DDRCTRL_DDRCTRL_PCFGW_1_WR_PORT_URGENT_EN        \ WR_PORT_URGENT_EN
$00004000 constant DDRCTRL_DDRCTRL_PCFGW_1_WR_PORT_PAGEMATCH_EN     \ WR_PORT_PAGEMATCH_EN


\
\ @brief DDRCTRL port 1 control register
\ Address offset: 0x540
\ Reset value: 0x00000000
\

$00000001 constant DDRCTRL_DDRCTRL_PCTRL_1_PORT_EN                  \ PORT_EN


\
\ @brief DDRCTRL port 1 read Q0S configuration register 0
\ Address offset: 0x544
\ Reset value: 0x02000E00
\

$0000000f constant DDRCTRL_DDRCTRL_PCFGQOS0_1_RQOS_MAP_LEVEL1       \ RQOS_MAP_LEVEL1
$00000f00 constant DDRCTRL_DDRCTRL_PCFGQOS0_1_RQOS_MAP_LEVEL2       \ RQOS_MAP_LEVEL2
$00030000 constant DDRCTRL_DDRCTRL_PCFGQOS0_1_RQOS_MAP_REGION0      \ RQOS_MAP_REGION0
$00300000 constant DDRCTRL_DDRCTRL_PCFGQOS0_1_RQOS_MAP_REGION1      \ RQOS_MAP_REGION1
$03000000 constant DDRCTRL_DDRCTRL_PCFGQOS0_1_RQOS_MAP_REGION2      \ RQOS_MAP_REGION2


\
\ @brief DDRCTRL port 1 read Q0S configuration register 1
\ Address offset: 0x548
\ Reset value: 0x00000000
\

$000007ff constant DDRCTRL_DDRCTRL_PCFGQOS1_1_RQOS_MAP_TIMEOUTB     \ RQOS_MAP_TIMEOUTB
$07ff0000 constant DDRCTRL_DDRCTRL_PCFGQOS1_1_RQOS_MAP_TIMEOUTR     \ RQOS_MAP_TIMEOUTR


\
\ @brief DDRCTRL port 1 write Q0S configuration register 0
\ Address offset: 0x54C
\ Reset value: 0x00000E00
\

$0000000f constant DDRCTRL_DDRCTRL_PCFGWQOS0_1_WQOS_MAP_LEVEL1      \ WQOS_MAP_LEVEL1
$00000f00 constant DDRCTRL_DDRCTRL_PCFGWQOS0_1_WQOS_MAP_LEVEL2      \ WQOS_MAP_LEVEL2
$00030000 constant DDRCTRL_DDRCTRL_PCFGWQOS0_1_WQOS_MAP_REGION0     \ WQOS_MAP_REGION0
$00300000 constant DDRCTRL_DDRCTRL_PCFGWQOS0_1_WQOS_MAP_REGION1     \ WQOS_MAP_REGION1
$03000000 constant DDRCTRL_DDRCTRL_PCFGWQOS0_1_WQOS_MAP_REGION2     \ WQOS_MAP_REGION2


\
\ @brief DDRCTRL port 1 write Q0S configuration register 1
\ Address offset: 0x550
\ Reset value: 0x00000000
\

$000007ff constant DDRCTRL_DDRCTRL_PCFGWQOS1_1_WQOS_MAP_TIMEOUT1    \ WQOS_MAP_TIMEOUT1
$07ff0000 constant DDRCTRL_DDRCTRL_PCFGWQOS1_1_WQOS_MAP_TIMEOUT2    \ WQOS_MAP_TIMEOUT2


\
\ @brief DDRCTRL
\
$5a003000 constant DDRCTRL_DDRCTRL_MSTR  \ offset: 0x00 : DDRCTRL master register 0
$5a003004 constant DDRCTRL_DDRCTRL_STAT  \ offset: 0x04 : DDRCTRL operating mode status register
$5a003010 constant DDRCTRL_DDRCTRL_MRCTRL0  \ offset: 0x10 : Mode Register Read/Write Control Register 0. Do not enable more than one of the following fields simultaneously: sw_init_int pda_en mpr_en
$5a003014 constant DDRCTRL_DDRCTRL_MRCTRL1  \ offset: 0x14 : DDRCTRL mode register read/write control register 1
$5a003018 constant DDRCTRL_DDRCTRL_MRSTAT  \ offset: 0x18 : DDRCTRL mode register read/write status register
$5a003020 constant DDRCTRL_DDRCTRL_DERATEEN  \ offset: 0x20 : DDRCTRL temperature derate enable register
$5a003024 constant DDRCTRL_DDRCTRL_DERATEINT  \ offset: 0x24 : DDRCTRL temperature derate interval register
$5a003030 constant DDRCTRL_DDRCTRL_PWRCTL  \ offset: 0x30 : DDRCTRL low power control register
$5a003034 constant DDRCTRL_DDRCTRL_PWRTMG  \ offset: 0x34 : DDRCTRL low power timing register
$5a003038 constant DDRCTRL_DDRCTRL_HWLPCTL  \ offset: 0x38 : DDRCTRL hardware low power control register
$5a003050 constant DDRCTRL_DDRCTRL_RFSHCTL0  \ offset: 0x50 : DDRCTRL refresh control register 0
$5a003060 constant DDRCTRL_DDRCTRL_RFSHCTL3  \ offset: 0x60 : DDRCTRL refresh control register 3
$5a003064 constant DDRCTRL_DDRCTRL_RFSHTMG  \ offset: 0x64 : DDRCTRL refresh timing register
$5a0030c0 constant DDRCTRL_DDRCTRL_CRCPARCTL0  \ offset: 0xC0 : DDRCTRL CRC parity control register 0
$5a0030cc constant DDRCTRL_DDRCTRL_CRCPARSTAT  \ offset: 0xCC : DDRCTRL CRC parity status register
$5a0030d0 constant DDRCTRL_DDRCTRL_INIT0  \ offset: 0xD0 : DDRCTRL SDRAM initialization register 0
$5a0030d4 constant DDRCTRL_DDRCTRL_INIT1  \ offset: 0xD4 : DDRCTRL SDRAM initialization register 1
$5a0030d8 constant DDRCTRL_DDRCTRL_INIT2  \ offset: 0xD8 : DDRCTRL SDRAM initialization register 2
$5a0030dc constant DDRCTRL_DDRCTRL_INIT3  \ offset: 0xDC : DDRCTRL SDRAM initialization register 3
$5a0030e0 constant DDRCTRL_DDRCTRL_INIT4  \ offset: 0xE0 : DDRCTRL SDRAM initialization register 4
$5a0030e4 constant DDRCTRL_DDRCTRL_INIT5  \ offset: 0xE4 : DDRCTRL SDRAM initialization register 5
$5a0030f0 constant DDRCTRL_DDRCTRL_DIMMCTL  \ offset: 0xF0 : DDRCTRL DIMM control register
$5a003100 constant DDRCTRL_DDRCTRL_DRAMTMG0  \ offset: 0x100 : DDRCTRL SDRAM timing register 0
$5a003104 constant DDRCTRL_DDRCTRL_DRAMTMG1  \ offset: 0x104 : DDRCTRL SDRAM timing register 1
$5a003108 constant DDRCTRL_DDRCTRL_DRAMTMG2  \ offset: 0x108 : DDRCTRL SDRAM timing register 2
$5a00310c constant DDRCTRL_DDRCTRL_DRAMTMG3  \ offset: 0x10C : DDRCTRL SDRAM timing register 3
$5a003110 constant DDRCTRL_DDRCTRL_DRAMTMG4  \ offset: 0x110 : DDRCTRL SDRAM timing register 4
$5a003114 constant DDRCTRL_DDRCTRL_DRAMTMG5  \ offset: 0x114 : DDRCTRL SDRAM timing register 5
$5a003118 constant DDRCTRL_DDRCTRL_DRAMTMG6  \ offset: 0x118 : DDRCTRL SDRAM timing register 6
$5a00311c constant DDRCTRL_DDRCTRL_DRAMTMG7  \ offset: 0x11C : DDRCTRL SDRAM timing register 7
$5a003120 constant DDRCTRL_DDRCTRL_DRAMTMG8  \ offset: 0x120 : DDRCTRL SDRAM timing register 8
$5a003138 constant DDRCTRL_DDRCTRL_DRAMTMG14  \ offset: 0x138 : DDRCTRL SDRAM timing register 14
$5a00313c constant DDRCTRL_DDRCTRL_DRAMTMG15  \ offset: 0x13C : DDRCTRL SDRAM timing register 15
$5a003180 constant DDRCTRL_DDRCTRL_ZQCTL0  \ offset: 0x180 : DDRCTRL ZQ control register 0
$5a003184 constant DDRCTRL_DDRCTRL_ZQCTL1  \ offset: 0x184 : DDRCTRL ZQ control register 1
$5a003188 constant DDRCTRL_DDRCTRL_ZQCTL2  \ offset: 0x188 : DDRCTRL ZQ control register 2
$5a00318c constant DDRCTRL_DDRCTRL_ZQSTAT  \ offset: 0x18C : DDRCTRL ZQ status register
$5a003190 constant DDRCTRL_DDRCTRL_DFITMG0  \ offset: 0x190 : DDRCTRL DFI timing register 0
$5a003194 constant DDRCTRL_DDRCTRL_DFITMG1  \ offset: 0x194 : DDRCTRL DFI timing register 1
$5a003198 constant DDRCTRL_DDRCTRL_DFILPCFG0  \ offset: 0x198 : DDRCTRL low power configuration register 0
$5a0031a0 constant DDRCTRL_DDRCTRL_DFIUPD0  \ offset: 0x1A0 : DDRCTRL DFI update register 0
$5a0031a4 constant DDRCTRL_DDRCTRL_DFIUPD1  \ offset: 0x1A4 : DDRCTRL DFI update register 1
$5a0031a8 constant DDRCTRL_DDRCTRL_DFIUPD2  \ offset: 0x1A8 : DDRCTRL DFI update register 2
$5a0031b0 constant DDRCTRL_DDRCTRL_DFIMISC  \ offset: 0x1B0 : DDRCTRL DFI miscellaneous control register
$5a0031bc constant DDRCTRL_DDRCTRL_DFISTAT  \ offset: 0x1BC : DDRCTRL DFI status register
$5a0031c4 constant DDRCTRL_DDRCTRL_DFIPHYMSTR  \ offset: 0x1C4 : DDRCTRL DFI PHY master register
$5a003204 constant DDRCTRL_DDRCTRL_ADDRMAP1  \ offset: 0x204 : DDRCTRL address map register 1
$5a003208 constant DDRCTRL_DDRCTRL_ADDRMAP2  \ offset: 0x208 : DDRCTRL address map register 2
$5a00320c constant DDRCTRL_DDRCTRL_ADDRMAP3  \ offset: 0x20C : DDRCTRL address map register 3
$5a003210 constant DDRCTRL_DDRCTRL_ADDRMAP4  \ offset: 0x210 : DDRCTRL address map register 4
$5a003214 constant DDRCTRL_DDRCTRL_ADDRMAP5  \ offset: 0x214 : DDRCTRL address map register 5
$5a003218 constant DDRCTRL_DDRCTRL_ADDRMAP6  \ offset: 0x218 : DDRCTRL address register 6
$5a003224 constant DDRCTRL_DDRCTRL_ADDRMAP9  \ offset: 0x224 : DDRCTRL address map register 9
$5a003228 constant DDRCTRL_DDRCTRL_ADDRMAP10  \ offset: 0x228 : DDRCTRL address map register 10
$5a00322c constant DDRCTRL_DDRCTRL_ADDRMAP11  \ offset: 0x22C : DDRCTRL address map register 11
$5a003240 constant DDRCTRL_DDRCTRL_ODTCFG  \ offset: 0x240 : DDRCTRL ODT configuration register
$5a003244 constant DDRCTRL_DDRCTRL_ODTMAP  \ offset: 0x244 : DDRCTRL ODT/Rank map register
$5a003250 constant DDRCTRL_DDRCTRL_SCHED  \ offset: 0x250 : DDRCTRL scheduler control register
$5a003254 constant DDRCTRL_DDRCTRL_SCHED1  \ offset: 0x254 : DDRCTRL scheduler control register 1
$5a00325c constant DDRCTRL_DDRCTRL_PERFHPR1  \ offset: 0x25C : DDRCTRL high priority read CAM register 1
$5a003264 constant DDRCTRL_DDRCTRL_PERFLPR1  \ offset: 0x264 : DDRCTRL low priority read CAM register 1
$5a00326c constant DDRCTRL_DDRCTRL_PERFWR1  \ offset: 0x26C : DDRCTRL write CAM register 1
$5a003300 constant DDRCTRL_DDRCTRL_DBG0  \ offset: 0x300 : DDRCTRL debug register 0
$5a003304 constant DDRCTRL_DDRCTRL_DBG1  \ offset: 0x304 : DDRCTRL debug register 1
$5a003308 constant DDRCTRL_DDRCTRL_DBGCAM  \ offset: 0x308 : DDRCTRL CAM debug register
$5a00330c constant DDRCTRL_DDRCTRL_DBGCMD  \ offset: 0x30C : DDRCTRL command debug register
$5a003310 constant DDRCTRL_DDRCTRL_DBGSTAT  \ offset: 0x310 : DDRCTRL status debug register
$5a003320 constant DDRCTRL_DDRCTRL_SWCTL  \ offset: 0x320 : DDRCTRL software register programming control enable
$5a003324 constant DDRCTRL_DDRCTRL_SWSTAT  \ offset: 0x324 : DDRCTRL software register programming control status
$5a00336c constant DDRCTRL_DDRCTRL_POISONCFG  \ offset: 0x36C : AXI Poison configuration register common for all AXI ports.
$5a003370 constant DDRCTRL_DDRCTRL_POISONSTAT  \ offset: 0x370 : DDRCTRL AXI Poison status register
$5a0033fc constant DDRCTRL_DDRCTRL_PSTAT  \ offset: 0x3FC : DDRCTRL port status register
$5a003400 constant DDRCTRL_DDRCTRL_PCCFG  \ offset: 0x400 : DDRCTRL port common configuration register
$5a003404 constant DDRCTRL_DDRCTRL_PCFGR_0  \ offset: 0x404 : DDRCTRL port 0 configuration read register
$5a003408 constant DDRCTRL_DDRCTRL_PCFGW_0  \ offset: 0x408 : DDRCTRL port 0 configuration write register
$5a003490 constant DDRCTRL_DDRCTRL_PCTRL_0  \ offset: 0x490 : DDRCTRL port 0 control register
$5a003494 constant DDRCTRL_DDRCTRL_PCFGQOS0_0  \ offset: 0x494 : DDRCTRL port 0 read Q0S configuration register 0
$5a003498 constant DDRCTRL_DDRCTRL_PCFGQOS1_0  \ offset: 0x498 : DDRCTRL port 0 read Q0S configuration register 1
$5a00349c constant DDRCTRL_DDRCTRL_PCFGWQOS0_0  \ offset: 0x49C : DDRCTRL port 0 write Q0S configuration register 0
$5a0034a0 constant DDRCTRL_DDRCTRL_PCFGWQOS1_0  \ offset: 0x4A0 : DDRCTRL port 0 write Q0S configuration register 1
$5a0034b4 constant DDRCTRL_DDRCTRL_PCFGR_1  \ offset: 0x4B4 : DDRCTRL port 1 configuration read register
$5a0034b8 constant DDRCTRL_DDRCTRL_PCFGW_1  \ offset: 0x4B8 : DDRCTRL port 1 configuration write register
$5a003540 constant DDRCTRL_DDRCTRL_PCTRL_1  \ offset: 0x540 : DDRCTRL port 1 control register
$5a003544 constant DDRCTRL_DDRCTRL_PCFGQOS0_1  \ offset: 0x544 : DDRCTRL port 1 read Q0S configuration register 0
$5a003548 constant DDRCTRL_DDRCTRL_PCFGQOS1_1  \ offset: 0x548 : DDRCTRL port 1 read Q0S configuration register 1
$5a00354c constant DDRCTRL_DDRCTRL_PCFGWQOS0_1  \ offset: 0x54C : DDRCTRL port 1 write Q0S configuration register 0
$5a003550 constant DDRCTRL_DDRCTRL_PCFGWQOS1_1  \ offset: 0x550 : DDRCTRL port 1 write Q0S configuration register 1

