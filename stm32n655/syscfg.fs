\
\ @file syscfg.fs
\ @brief System configuration controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SYSCFG_DEF

  [ifdef] SYSCFG_SYSCFG_BOOTCR_DEF
    \
    \ @brief SYSCFG boot pin control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_BOOT0_PD                \ [0x00] BOOT0 pin pull-down disable
    $01 constant SYSCFG_BOOT1_PD                \ [0x01] BOOT1 pin pull-down disable
  [then]


  [ifdef] SYSCFG_SYSCFG_CM55CR_DEF
    \
    \ @brief SYSCFG Cortex-M55 control register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_FPU_IT_EN               \ [0x00 : 6] Enable FPU exception
    $10 constant SYSCFG_LOCKSVTAIRCR            \ [0x10] Prevent changes to:
    $11 constant SYSCFG_LOCKNSVTOR              \ [0x11] Prevent changes to the non-secure vector table base address.
    $12 constant SYSCFG_LOCKSMPU                \ [0x12] Prevent changes to programmed secure MPU memory regions.
    $13 constant SYSCFG_LOCKNSMPU               \ [0x13] Prevent changes to non-secure MPU memory regions already programmed.
    $14 constant SYSCFG_LOCKSAU                 \ [0x14] Prevent changes to secure SAU memory regions already programmed.
    $15 constant SYSCFG_LOCKDCAIC               \ [0x15] Disable access to the instruction cache direct cache access registers DCAICLR and DCAICRR.
  [then]


  [ifdef] SYSCFG_SYSCFG_CM55TCMCR_DEF
    \
    \ @brief SYSCFG Cortex-M55 TCM control register
    \ Address offset: 0x08
    \ Reset value: 0x00000087
    \
    $00 constant SYSCFG_CFGITCMSZ               \ [0x00 : 4] Select ITCM memory size
    $04 constant SYSCFG_CFGDTCMSZ               \ [0x04 : 4] Select DTCM memory size
    $10 constant SYSCFG_LOCKTCM                 \ [0x10] Disable writes to registers associated with the TCM region
    $11 constant SYSCFG_LOCKITGU                \ [0x11] Disable writes to registers associated with the ITCM interface security gating.
    $12 constant SYSCFG_LOCKDTGU                \ [0x12] Disable writes to registers associated with the DTCM interface security gating.
    $17 constant SYSCFG_ITCMWSDISABLE           \ [0x17] Disable wait-state applied by default on extended ITCM memory.
    $18 constant SYSCFG_DTCMWSDISABLE           \ [0x18] Disable wait-state applied by default on extended DTCM memory.
  [then]


  [ifdef] SYSCFG_SYSCFG_CM55RWMCR_DEF
    \
    \ @brief SYSCFG Cortex-CM55 memory RW margin register
    \ Address offset: 0x0C
    \ Reset value: 0x00001020
    \
    $00 constant SYSCFG_RME_TCM                 \ [0x00] RW margin enable input for TCM memories
    $01 constant SYSCFG_RM_TCM                  \ [0x01 : 4] External RW margin inputs for TCM memories
    $05 constant SYSCFG_BC1_TCM                 \ [0x05] Biasing level adjust input recommended for Vnom
    $06 constant SYSCFG_BC2_TCM                 \ [0x06] Biasing level adjust input recommended for Vnom + 10%
    $07 constant SYSCFG_RME_CACHE               \ [0x07] RW margin enable input for caches memories
    $08 constant SYSCFG_RM_CACHE                \ [0x08 : 4] External read/write (RW) margin inputs for caches memories
    $0c constant SYSCFG_BC1_CACHE               \ [0x0c] Biasing level adjust input recommended for Vnom.
    $0d constant SYSCFG_BC2_CACHE               \ [0x0d] Biasing level adjust input recommended for Vnom + 10%
  [then]


  [ifdef] SYSCFG_SYSCFG_INITSVTORCR_DEF
    \
    \ @brief SYSCFG Cortex-M55 SVTOR control register
    \ Address offset: 0x10
    \ Reset value: 0x18000000
    \
    $07 constant SYSCFG_SVTOR_ADDR              \ [0x07 : 25] Secure vector table base address
  [then]


  [ifdef] SYSCFG_SYSCFG_INITNSVTORCR_DEF
    \
    \ @brief SYSCFG Cortex-M55 NSVTOR control register
    \ Address offset: 0x14
    \ Reset value: 0x08000000
    \
    $07 constant SYSCFG_NSVTOR_ADDR             \ [0x07 : 25] Non-secure vector table base address
  [then]


  [ifdef] SYSCFG_SYSCFG_CM55RSTCR_DEF
    \
    \ @brief SYSCFG Cortex-M55 reset type control register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_CORE_RESET_TYPE         \ [0x00] Select reset to apply on core upon SYSRESETREQ
    $01 constant SYSCFG_LOCKUP_RST_EN           \ [0x01] Select action to perform on a lockup state on the core
    $02 constant SYSCFG_LOCKUP_NMI_EN           \ [0x02] Select action to perform on a lockup state on the core
  [then]


  [ifdef] SYSCFG_SYSCFG_CM55PAHBWPR_DEF
    \
    \ @brief SYSCFG Cortex-M55 P-AHB write posting control register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_PAHB_ERROR_ACK          \ [0x00] Error capture in write posting buffer
  [then]


  [ifdef] SYSCFG_SYSCFG_VENCRAMCR_DEF
    \
    \ @brief SYSCFG VENCRAM control register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_VENCRAM_EN              \ [0x00] VENCRAM allocation VENC if active, or to system (if VENC inactive)
  [then]


  [ifdef] SYSCFG_SYSCFG_POTTAMPRSTCR_DEF
    \
    \ @brief SYSCFG potential tamper reset register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_POTTAMPERSETMASK        \ [0x00] This bit can be set by software to mask PKA, SAES, CRYP1/2, and HASH reset, in case of potential tamper.
  [then]


  [ifdef] SYSCFG_SYSCFG_ICNEWRCR_DEF
    \
    \ @brief SYSCFG AHB-AXI bridge early write response control register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_SDMMC1_EARLY_WR_RSP_ENABLE     \ [0x00] None
    $01 constant SYSCFG_SDMMC2_EARLY_WR_RSP_ENABLE     \ [0x01] None
    $02 constant SYSCFG_USB1_EARLY_WR_RSP_ENABLE     \ [0x02] None
    $03 constant SYSCFG_USB2_EARLY_WR_RSP_ENABLE     \ [0x03] None
  [then]


  [ifdef] SYSCFG_SYSCFG_ICNCGCR_DEF
    \
    \ @brief SYSCFG ICN clock gating control register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_ICNCGCR                 \ [0x00 : 32] When bit[i] is set to 1, ICN clock gating[i] is OFF.
  [then]


  [ifdef] SYSCFG_SYSCFG_ICNBWRCR_DEF
    \
    \ @brief SYSCFG ICN bandwidth regulator control register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_ICNBWRCR                \ [0x00 : 32] Bandwidth regulator control bits
  [then]


  [ifdef] SYSCFG_SYSCFG_IOCR_DEF
    \
    \ @brief SYSCFG /O control register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_IOCR                    \ [0x00 : 32] Digital or analog pins
  [then]


  [ifdef] SYSCFG_SYSCFG_VDDIO1CCCR_DEF
    \
    \ @brief SYSCFG VDDIO1 compensation cell control register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_RANSRC                  \ [0x00 : 4] These bits are written by software to define an I/O compensation code for NMOS transistors. This code is applied to the I/O compensation cell when the CS = 1.
    $04 constant SYSCFG_RAPSRC                  \ [0x04 : 4] These bits are written by software to define an I/O compensation code for PMOS transistors. This code is applied to the I/O compensation cell when CS = 1.
    $08 constant SYSCFG_EN                      \ [0x08] Enables the compensation cell of I/Os supplied by VDDIOx.
    $09 constant SYSCFG_CS                      \ [0x09] Selects the code to be applied for the compensation cell of I/Os supplied by VDDIOx.
  [then]


  [ifdef] SYSCFG_SYSCFG_VDDIO1CCSR_DEF
    \
    \ @brief SYSCFG VDDIO1 compensation cell status register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_ANSRC                   \ [0x00 : 4] This value is provided by the cell, and can be used by the CPU to compute an I/O compensation cell code for NMOS transistors.
    $04 constant SYSCFG_APSRC                   \ [0x04 : 4] This value is provided by the cell, and can be used by the CPU to compute an I/O compensation cell code for PMOS transistors.
    $08 constant SYSCFG_READY                   \ [0x08] Provides the compensation cell status of I/Os supplied by VDDIOx
  [then]


  [ifdef] SYSCFG_SYSCFG_VDDIO2CCCR_DEF
    \
    \ @brief SYSCFG VDDIO2 compensation cell control register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_RANSRC                  \ [0x00 : 4] These bits are written by software to define an I/O compensation code for NMOS transistors. This code is applied to the I/O compensation cell when the CS = 1.
    $04 constant SYSCFG_RAPSRC                  \ [0x04 : 4] These bits are written by software to define an I/O compensation code for PMOS transistors. This code is applied to the I/O compensation cell when CS = 1.
    $08 constant SYSCFG_EN                      \ [0x08] Enables the compensation cell of I/Os supplied by VDDIOx.
    $09 constant SYSCFG_CS                      \ [0x09] Selects the code to be applied for the compensation cell of I/Os supplied by VDDIOx.
  [then]


  [ifdef] SYSCFG_SYSCFG_VDDIO2CCSR_DEF
    \
    \ @brief SYSCFG VDDIO2 compensation cell status register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_ANSRC                   \ [0x00 : 4] This value is provided by the cell, and can be used by the CPU to compute an I/O compensation cell code for NMOS transistors.
    $04 constant SYSCFG_APSRC                   \ [0x04 : 4] This value is provided by the cell, and can be used by the CPU to compute an I/O compensation cell code for PMOS transistors.
    $08 constant SYSCFG_READY                   \ [0x08] Provides the compensation cell status of I/Os supplied by VDDIOx
  [then]


  [ifdef] SYSCFG_SYSCFG_VDDIO3CCCR_DEF
    \
    \ @brief SYSCFG VDDIO3 compensation cell control register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_RANSRC                  \ [0x00 : 4] These bits are written by software to define an I/O compensation code for NMOS transistors. This code is applied to the I/O compensation cell when the CS = 1.
    $04 constant SYSCFG_RAPSRC                  \ [0x04 : 4] These bits are written by software to define an I/O compensation code for PMOS transistors. This code is applied to the I/O compensation cell when CS = 1.
    $08 constant SYSCFG_EN                      \ [0x08] Enables the compensation cell of I/Os supplied by VDDIOx.
    $09 constant SYSCFG_CS                      \ [0x09] Selects the code to be applied for the compensation cell of I/Os supplied by VDDIOx.
  [then]


  [ifdef] SYSCFG_SYSCFG_VDDIO3CCSR_DEF
    \
    \ @brief SYSCFG VDDIO3 compensation cell status register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_ANSRC                   \ [0x00 : 4] This value is provided by the cell, and can be used by the CPU to compute an I/O compensation cell code for NMOS transistors.
    $04 constant SYSCFG_APSRC                   \ [0x04 : 4] This value is provided by the cell, and can be used by the CPU to compute an I/O compensation cell code for PMOS transistors.
    $08 constant SYSCFG_READY                   \ [0x08] Provides the compensation cell status of I/Os supplied by VDDIOx
  [then]


  [ifdef] SYSCFG_SYSCFG_VDDIO4CCCR_DEF
    \
    \ @brief SYSCFG VDDIO4 compensation cell control register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_RANSRC                  \ [0x00 : 4] These bits are written by software to define an I/O compensation code for NMOS transistors. This code is applied to the I/O compensation cell when the CS = 1.
    $04 constant SYSCFG_RAPSRC                  \ [0x04 : 4] These bits are written by software to define an I/O compensation code for PMOS transistors. This code is applied to the I/O compensation cell when CS = 1.
    $08 constant SYSCFG_EN                      \ [0x08] Enables the compensation cell of I/Os supplied by VDDIOx.
    $09 constant SYSCFG_CS                      \ [0x09] Selects the code to be applied for the compensation cell of I/Os supplied by VDDIOx.
  [then]


  [ifdef] SYSCFG_SYSCFG_VDDIO4CCSR_DEF
    \
    \ @brief SYSCFG VDDIO4 compensation cell status register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_ANSRC                   \ [0x00 : 4] This value is provided by the cell, and can be used by the CPU to compute an I/O compensation cell code for NMOS transistors.
    $04 constant SYSCFG_APSRC                   \ [0x04 : 4] This value is provided by the cell, and can be used by the CPU to compute an I/O compensation cell code for PMOS transistors.
    $08 constant SYSCFG_READY                   \ [0x08] Provides the compensation cell status of I/Os supplied by VDDIOx
  [then]


  [ifdef] SYSCFG_SYSCFG_VDDIOCCCR_DEF
    \
    \ @brief SYSCFG VDDIO compensation cell control register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_RANSRC                  \ [0x00 : 4] These bits are written by software to define an I/O compensation code for NMOS transistors. This code is applied to the I/O compensation cell when CS = 1.
    $04 constant SYSCFG_RAPSRC                  \ [0x04 : 4] These bits are written by software to define an I/O compensation code for PMOS transistors. This code is applied to the I/O compensation cell when CS = 1.
    $08 constant SYSCFG_EN                      \ [0x08] Enables the compensation cell of I/Os supplied by VDDIO.
    $09 constant SYSCFG_CS                      \ [0x09] Selects the code to be applied for the compensation cell of I/Os supplied by VDDIO.
  [then]


  [ifdef] SYSCFG_SYSCFG_VDDIOCCSR_DEF
    \
    \ @brief SYSCFG VDDIO compensation cell status register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_ANSRC                   \ [0x00 : 4] This value is provided by the cell, and can be used by the CPU to compute an I/O compensation cell code for NMOS transistors.
    $04 constant SYSCFG_APSRC                   \ [0x04 : 4] This value is provided by the cell, and can be used by the CPU to compute an I/O compensation cell code for PMOS transistors.
    $08 constant SYSCFG_READY                   \ [0x08] Provides the compensation cell status of I/Os supplied by VDDIO
  [then]


  [ifdef] SYSCFG_SYSCFG_CBR_DEF
    \
    \ @brief SYSCFG control timer break register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_CM55L                   \ [0x00] CM55 lockup lock enable
    $02 constant SYSCFG_PVDL_LOCK               \ [0x02] PVD lock enable
    $03 constant SYSCFG_BKPRAML                 \ [0x03] Backup SRAM double ECC error lock
    $05 constant SYSCFG_CM55CACHEL              \ [0x05] CM55 cache double ECC error lock
    $06 constant SYSCFG_CM55TCML                \ [0x06] CM55 TCM double ECC error lock
  [then]


  [ifdef] SYSCFG_SYSCFG_SEC_AIDCR_DEF
    \
    \ @brief SYSCFG DMA CID secure control register
    \ Address offset: 0x70
    \ Reset value: 0x00000001
    \
    $00 constant SYSCFG_DMACID_SEC              \ [0x00 : 3] Secure OS allocates specific CID to DMA channel through these bits.
  [then]


  [ifdef] SYSCFG_SYSCFG_FMC_RETIMECR_DEF
    \
    \ @brief SYSCFG FMC retiming logic control register
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_CFG_RETIME_RX           \ [0x00] Retiming on Rx path
    $01 constant SYSCFG_CFG_RETIME_TX           \ [0x01] Retiming on Tx path
    $02 constant SYSCFG_SDFBCLK_180             \ [0x02] Delay on feedback clock
  [then]


  [ifdef] SYSCFG_SYSCFG_NPU_ICNCR_DEF
    \
    \ @brief SYSCFG NPU RAM interleaving control register
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_INTERLEAVING_ACTIVE     \ [0x00] Control interleaving on NPU RAMs
  [then]


  [ifdef] SYSCFG_SYSCFG_BOOTSR_DEF
    \
    \ @brief SYSCFG boot pin status register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_BOOT0                   \ [0x00] BOOT0 pin value
    $01 constant SYSCFG_BOOT1                   \ [0x01] BOOT1 pin value
  [then]


  [ifdef] SYSCFG_SYSCFG_AHBWP_ERROR_SR_DEF
    \
    \ @brief SYSCFG AHB write posting address error register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_PAHB_ERROR_ADDR         \ [0x00 : 32] Reports address of the first error in P-AHB write-posting buffer
  [then]


  [ifdef] SYSCFG_SYSCFG_SMPSHDPCR_DEF
    \
    \ @brief SYSCFG SMPS observable signals through HDP selection configuration register
    \ Address offset: 0x400
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_SMPSHDPSEL              \ [0x00 : 4] Others: Reserved
  [then]


  [ifdef] SYSCFG_SYSCFG_NONSEC_AIDCR_DEF
    \
    \ @brief SYSCFG DMA CID non-secure control register
    \ Address offset: 0x800
    \ Reset value: 0x00000001
    \
    $00 constant SYSCFG_DMACID_NONSEC           \ [0x00 : 3] Non-secure OS allocates specific CID to DMA channel through these bits
  [then]

  \
  \ @brief System configuration controller
  \
  $00 constant SYSCFG_SYSCFG_BOOTCR     \ SYSCFG boot pin control register
  $04 constant SYSCFG_SYSCFG_CM55CR     \ SYSCFG Cortex-M55 control register
  $08 constant SYSCFG_SYSCFG_CM55TCMCR  \ SYSCFG Cortex-M55 TCM control register
  $0C constant SYSCFG_SYSCFG_CM55RWMCR  \ SYSCFG Cortex-CM55 memory RW margin register
  $10 constant SYSCFG_SYSCFG_INITSVTORCR    \ SYSCFG Cortex-M55 SVTOR control register
  $14 constant SYSCFG_SYSCFG_INITNSVTORCR    \ SYSCFG Cortex-M55 NSVTOR control register
  $18 constant SYSCFG_SYSCFG_CM55RSTCR  \ SYSCFG Cortex-M55 reset type control register
  $1C constant SYSCFG_SYSCFG_CM55PAHBWPR    \ SYSCFG Cortex-M55 P-AHB write posting control register
  $20 constant SYSCFG_SYSCFG_VENCRAMCR  \ SYSCFG VENCRAM control register
  $24 constant SYSCFG_SYSCFG_POTTAMPRSTCR    \ SYSCFG potential tamper reset register
  $34 constant SYSCFG_SYSCFG_ICNEWRCR   \ SYSCFG AHB-AXI bridge early write response control register
  $38 constant SYSCFG_SYSCFG_ICNCGCR    \ SYSCFG ICN clock gating control register
  $3C constant SYSCFG_SYSCFG_ICNBWRCR   \ SYSCFG ICN bandwidth regulator control register
  $40 constant SYSCFG_SYSCFG_IOCR       \ SYSCFG /O control register
  $44 constant SYSCFG_SYSCFG_VDDIO1CCCR \ SYSCFG VDDIO1 compensation cell control register
  $48 constant SYSCFG_SYSCFG_VDDIO1CCSR \ SYSCFG VDDIO1 compensation cell status register
  $4C constant SYSCFG_SYSCFG_VDDIO2CCCR \ SYSCFG VDDIO2 compensation cell control register
  $50 constant SYSCFG_SYSCFG_VDDIO2CCSR \ SYSCFG VDDIO2 compensation cell status register
  $54 constant SYSCFG_SYSCFG_VDDIO3CCCR \ SYSCFG VDDIO3 compensation cell control register
  $58 constant SYSCFG_SYSCFG_VDDIO3CCSR \ SYSCFG VDDIO3 compensation cell status register
  $5C constant SYSCFG_SYSCFG_VDDIO4CCCR \ SYSCFG VDDIO4 compensation cell control register
  $60 constant SYSCFG_SYSCFG_VDDIO4CCSR \ SYSCFG VDDIO4 compensation cell status register
  $64 constant SYSCFG_SYSCFG_VDDIOCCCR  \ SYSCFG VDDIO compensation cell control register
  $68 constant SYSCFG_SYSCFG_VDDIOCCSR  \ SYSCFG VDDIO compensation cell status register
  $6C constant SYSCFG_SYSCFG_CBR        \ SYSCFG control timer break register
  $70 constant SYSCFG_SYSCFG_SEC_AIDCR  \ SYSCFG DMA CID secure control register
  $74 constant SYSCFG_SYSCFG_FMC_RETIMECR    \ SYSCFG FMC retiming logic control register
  $78 constant SYSCFG_SYSCFG_NPU_ICNCR  \ SYSCFG NPU RAM interleaving control register
  $100 constant SYSCFG_SYSCFG_BOOTSR    \ SYSCFG boot pin status register
  $104 constant SYSCFG_SYSCFG_AHBWP_ERROR_SR    \ SYSCFG AHB write posting address error register
  $400 constant SYSCFG_SYSCFG_SMPSHDPCR \ SYSCFG SMPS observable signals through HDP selection configuration register
  $800 constant SYSCFG_SYSCFG_NONSEC_AIDCR    \ SYSCFG DMA CID non-secure control register

: SYSCFG_DEF ; [then]
