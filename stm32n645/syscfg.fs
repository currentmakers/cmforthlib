\
\ @file syscfg.fs
\ @brief System configuration controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief SYSCFG boot pin control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_BOOTCR_BOOT0_PD                    \ BOOT0 pin pull-down disable
$00000002 constant SYSCFG_SYSCFG_BOOTCR_BOOT1_PD                    \ BOOT1 pin pull-down disable


\
\ @brief SYSCFG Cortex-M55 control register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000003f constant SYSCFG_SYSCFG_CM55CR_FPU_IT_EN                   \ Enable FPU exception
$00010000 constant SYSCFG_SYSCFG_CM55CR_LOCKSVTAIRCR                \ Prevent changes to:
$00020000 constant SYSCFG_SYSCFG_CM55CR_LOCKNSVTOR                  \ Prevent changes to the non-secure vector table base address.
$00040000 constant SYSCFG_SYSCFG_CM55CR_LOCKSMPU                    \ Prevent changes to programmed secure MPU memory regions.
$00080000 constant SYSCFG_SYSCFG_CM55CR_LOCKNSMPU                   \ Prevent changes to non-secure MPU memory regions already programmed.
$00100000 constant SYSCFG_SYSCFG_CM55CR_LOCKSAU                     \ Prevent changes to secure SAU memory regions already programmed.
$00200000 constant SYSCFG_SYSCFG_CM55CR_LOCKDCAIC                   \ Disable access to the instruction cache direct cache access registers DCAICLR and DCAICRR.


\
\ @brief SYSCFG Cortex-M55 TCM control register
\ Address offset: 0x08
\ Reset value: 0x00000087
\

$0000000f constant SYSCFG_SYSCFG_CM55TCMCR_CFGITCMSZ                \ Select ITCM memory size
$000000f0 constant SYSCFG_SYSCFG_CM55TCMCR_CFGDTCMSZ                \ Select DTCM memory size
$00010000 constant SYSCFG_SYSCFG_CM55TCMCR_LOCKTCM                  \ Disable writes to registers associated with the TCM region
$00020000 constant SYSCFG_SYSCFG_CM55TCMCR_LOCKITGU                 \ Disable writes to registers associated with the ITCM interface security gating.
$00040000 constant SYSCFG_SYSCFG_CM55TCMCR_LOCKDTGU                 \ Disable writes to registers associated with the DTCM interface security gating.
$00800000 constant SYSCFG_SYSCFG_CM55TCMCR_ITCMWSDISABLE            \ Disable wait-state applied by default on extended ITCM memory.
$01000000 constant SYSCFG_SYSCFG_CM55TCMCR_DTCMWSDISABLE            \ Disable wait-state applied by default on extended DTCM memory.


\
\ @brief SYSCFG Cortex-CM55 memory RW margin register
\ Address offset: 0x0C
\ Reset value: 0x00001020
\

$00000001 constant SYSCFG_SYSCFG_CM55RWMCR_RME_TCM                  \ RW margin enable input for TCM memories
$0000001e constant SYSCFG_SYSCFG_CM55RWMCR_RM_TCM                   \ External RW margin inputs for TCM memories
$00000020 constant SYSCFG_SYSCFG_CM55RWMCR_BC1_TCM                  \ Biasing level adjust input recommended for Vnom
$00000040 constant SYSCFG_SYSCFG_CM55RWMCR_BC2_TCM                  \ Biasing level adjust input recommended for Vnom + 10%
$00000080 constant SYSCFG_SYSCFG_CM55RWMCR_RME_CACHE                \ RW margin enable input for caches memories
$00000f00 constant SYSCFG_SYSCFG_CM55RWMCR_RM_CACHE                 \ External read/write (RW) margin inputs for caches memories
$00001000 constant SYSCFG_SYSCFG_CM55RWMCR_BC1_CACHE                \ Biasing level adjust input recommended for Vnom.
$00002000 constant SYSCFG_SYSCFG_CM55RWMCR_BC2_CACHE                \ Biasing level adjust input recommended for Vnom + 10%


\
\ @brief SYSCFG Cortex-M55 SVTOR control register
\ Address offset: 0x10
\ Reset value: 0x18000000
\

$ffffff80 constant SYSCFG_SYSCFG_INITSVTORCR_SVTOR_ADDR             \ Secure vector table base address


\
\ @brief SYSCFG Cortex-M55 NSVTOR control register
\ Address offset: 0x14
\ Reset value: 0x08000000
\

$ffffff80 constant SYSCFG_SYSCFG_INITNSVTORCR_NSVTOR_ADDR           \ Non-secure vector table base address


\
\ @brief SYSCFG Cortex-M55 reset type control register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_CM55RSTCR_CORE_RESET_TYPE          \ Select reset to apply on core upon SYSRESETREQ
$00000002 constant SYSCFG_SYSCFG_CM55RSTCR_LOCKUP_RST_EN            \ Select action to perform on a lockup state on the core
$00000004 constant SYSCFG_SYSCFG_CM55RSTCR_LOCKUP_NMI_EN            \ Select action to perform on a lockup state on the core


\
\ @brief SYSCFG Cortex-M55 P-AHB write posting control register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_CM55PAHBWPR_PAHB_ERROR_ACK         \ Error capture in write posting buffer


\
\ @brief SYSCFG VENCRAM control register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_VENCRAMCR_VENCRAM_EN               \ VENCRAM allocation VENC if active, or to system (if VENC inactive)


\
\ @brief SYSCFG potential tamper reset register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_POTTAMPRSTCR_POTTAMPERSETMASK      \ This bit can be set by software to mask PKA, SAES, CRYP1/2, and HASH reset, in case of potential tamper.


\
\ @brief SYSCFG AHB-AXI bridge early write response control register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ICNEWRCR_SDMMC1_EARLY_WR_RSP_ENABLE    \ None
$00000002 constant SYSCFG_SYSCFG_ICNEWRCR_SDMMC2_EARLY_WR_RSP_ENABLE    \ None
$00000004 constant SYSCFG_SYSCFG_ICNEWRCR_USB1_EARLY_WR_RSP_ENABLE    \ None
$00000008 constant SYSCFG_SYSCFG_ICNEWRCR_USB2_EARLY_WR_RSP_ENABLE    \ None


\
\ @brief SYSCFG ICN clock gating control register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant SYSCFG_SYSCFG_ICNCGCR_ICNCGCR                    \ When bit[i] is set to 1, ICN clock gating[i] is OFF.


\
\ @brief SYSCFG ICN bandwidth regulator control register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant SYSCFG_SYSCFG_ICNBWRCR_ICNBWRCR                  \ Bandwidth regulator control bits


\
\ @brief SYSCFG /O control register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant SYSCFG_SYSCFG_IOCR_IOCR                          \ Digital or analog pins


\
\ @brief SYSCFG VDDIO1 compensation cell control register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$0000000f constant SYSCFG_SYSCFG_VDDIO1CCCR_RANSRC                  \ These bits are written by software to define an I/O compensation code for NMOS transistors. This code is applied to the I/O compensation cell when the CS = 1.
$000000f0 constant SYSCFG_SYSCFG_VDDIO1CCCR_RAPSRC                  \ These bits are written by software to define an I/O compensation code for PMOS transistors. This code is applied to the I/O compensation cell when CS = 1.
$00000100 constant SYSCFG_SYSCFG_VDDIO1CCCR_EN                      \ Enables the compensation cell of I/Os supplied by VDDIOx.
$00000200 constant SYSCFG_SYSCFG_VDDIO1CCCR_CS                      \ Selects the code to be applied for the compensation cell of I/Os supplied by VDDIOx.


\
\ @brief SYSCFG VDDIO1 compensation cell status register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000000f constant SYSCFG_SYSCFG_VDDIO1CCSR_ANSRC                   \ This value is provided by the cell, and can be used by the CPU to compute an I/O compensation cell code for NMOS transistors.
$000000f0 constant SYSCFG_SYSCFG_VDDIO1CCSR_APSRC                   \ This value is provided by the cell, and can be used by the CPU to compute an I/O compensation cell code for PMOS transistors.
$00000100 constant SYSCFG_SYSCFG_VDDIO1CCSR_READY                   \ Provides the compensation cell status of I/Os supplied by VDDIOx


\
\ @brief SYSCFG VDDIO2 compensation cell control register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$0000000f constant SYSCFG_SYSCFG_VDDIO2CCCR_RANSRC                  \ These bits are written by software to define an I/O compensation code for NMOS transistors. This code is applied to the I/O compensation cell when the CS = 1.
$000000f0 constant SYSCFG_SYSCFG_VDDIO2CCCR_RAPSRC                  \ These bits are written by software to define an I/O compensation code for PMOS transistors. This code is applied to the I/O compensation cell when CS = 1.
$00000100 constant SYSCFG_SYSCFG_VDDIO2CCCR_EN                      \ Enables the compensation cell of I/Os supplied by VDDIOx.
$00000200 constant SYSCFG_SYSCFG_VDDIO2CCCR_CS                      \ Selects the code to be applied for the compensation cell of I/Os supplied by VDDIOx.


\
\ @brief SYSCFG VDDIO2 compensation cell status register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$0000000f constant SYSCFG_SYSCFG_VDDIO2CCSR_ANSRC                   \ This value is provided by the cell, and can be used by the CPU to compute an I/O compensation cell code for NMOS transistors.
$000000f0 constant SYSCFG_SYSCFG_VDDIO2CCSR_APSRC                   \ This value is provided by the cell, and can be used by the CPU to compute an I/O compensation cell code for PMOS transistors.
$00000100 constant SYSCFG_SYSCFG_VDDIO2CCSR_READY                   \ Provides the compensation cell status of I/Os supplied by VDDIOx


\
\ @brief SYSCFG VDDIO3 compensation cell control register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$0000000f constant SYSCFG_SYSCFG_VDDIO3CCCR_RANSRC                  \ These bits are written by software to define an I/O compensation code for NMOS transistors. This code is applied to the I/O compensation cell when the CS = 1.
$000000f0 constant SYSCFG_SYSCFG_VDDIO3CCCR_RAPSRC                  \ These bits are written by software to define an I/O compensation code for PMOS transistors. This code is applied to the I/O compensation cell when CS = 1.
$00000100 constant SYSCFG_SYSCFG_VDDIO3CCCR_EN                      \ Enables the compensation cell of I/Os supplied by VDDIOx.
$00000200 constant SYSCFG_SYSCFG_VDDIO3CCCR_CS                      \ Selects the code to be applied for the compensation cell of I/Os supplied by VDDIOx.


\
\ @brief SYSCFG VDDIO3 compensation cell status register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$0000000f constant SYSCFG_SYSCFG_VDDIO3CCSR_ANSRC                   \ This value is provided by the cell, and can be used by the CPU to compute an I/O compensation cell code for NMOS transistors.
$000000f0 constant SYSCFG_SYSCFG_VDDIO3CCSR_APSRC                   \ This value is provided by the cell, and can be used by the CPU to compute an I/O compensation cell code for PMOS transistors.
$00000100 constant SYSCFG_SYSCFG_VDDIO3CCSR_READY                   \ Provides the compensation cell status of I/Os supplied by VDDIOx


\
\ @brief SYSCFG VDDIO4 compensation cell control register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$0000000f constant SYSCFG_SYSCFG_VDDIO4CCCR_RANSRC                  \ These bits are written by software to define an I/O compensation code for NMOS transistors. This code is applied to the I/O compensation cell when the CS = 1.
$000000f0 constant SYSCFG_SYSCFG_VDDIO4CCCR_RAPSRC                  \ These bits are written by software to define an I/O compensation code for PMOS transistors. This code is applied to the I/O compensation cell when CS = 1.
$00000100 constant SYSCFG_SYSCFG_VDDIO4CCCR_EN                      \ Enables the compensation cell of I/Os supplied by VDDIOx.
$00000200 constant SYSCFG_SYSCFG_VDDIO4CCCR_CS                      \ Selects the code to be applied for the compensation cell of I/Os supplied by VDDIOx.


\
\ @brief SYSCFG VDDIO4 compensation cell status register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$0000000f constant SYSCFG_SYSCFG_VDDIO4CCSR_ANSRC                   \ This value is provided by the cell, and can be used by the CPU to compute an I/O compensation cell code for NMOS transistors.
$000000f0 constant SYSCFG_SYSCFG_VDDIO4CCSR_APSRC                   \ This value is provided by the cell, and can be used by the CPU to compute an I/O compensation cell code for PMOS transistors.
$00000100 constant SYSCFG_SYSCFG_VDDIO4CCSR_READY                   \ Provides the compensation cell status of I/Os supplied by VDDIOx


\
\ @brief SYSCFG VDDIO compensation cell control register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$0000000f constant SYSCFG_SYSCFG_VDDIOCCCR_RANSRC                   \ These bits are written by software to define an I/O compensation code for NMOS transistors. This code is applied to the I/O compensation cell when CS = 1.
$000000f0 constant SYSCFG_SYSCFG_VDDIOCCCR_RAPSRC                   \ These bits are written by software to define an I/O compensation code for PMOS transistors. This code is applied to the I/O compensation cell when CS = 1.
$00000100 constant SYSCFG_SYSCFG_VDDIOCCCR_EN                       \ Enables the compensation cell of I/Os supplied by VDDIO.
$00000200 constant SYSCFG_SYSCFG_VDDIOCCCR_CS                       \ Selects the code to be applied for the compensation cell of I/Os supplied by VDDIO.


\
\ @brief SYSCFG VDDIO compensation cell status register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$0000000f constant SYSCFG_SYSCFG_VDDIOCCSR_ANSRC                    \ This value is provided by the cell, and can be used by the CPU to compute an I/O compensation cell code for NMOS transistors.
$000000f0 constant SYSCFG_SYSCFG_VDDIOCCSR_APSRC                    \ This value is provided by the cell, and can be used by the CPU to compute an I/O compensation cell code for PMOS transistors.
$00000100 constant SYSCFG_SYSCFG_VDDIOCCSR_READY                    \ Provides the compensation cell status of I/Os supplied by VDDIO


\
\ @brief SYSCFG control timer break register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_CBR_CM55L                          \ CM55 lockup lock enable
$00000004 constant SYSCFG_SYSCFG_CBR_PVDL_LOCK                      \ PVD lock enable
$00000008 constant SYSCFG_SYSCFG_CBR_BKPRAML                        \ Backup SRAM double ECC error lock
$00000020 constant SYSCFG_SYSCFG_CBR_CM55CACHEL                     \ CM55 cache double ECC error lock
$00000040 constant SYSCFG_SYSCFG_CBR_CM55TCML                       \ CM55 TCM double ECC error lock


\
\ @brief SYSCFG DMA CID secure control register
\ Address offset: 0x70
\ Reset value: 0x00000001
\

$00000007 constant SYSCFG_SYSCFG_SEC_AIDCR_DMACID_SEC               \ Secure OS allocates specific CID to DMA channel through these bits.


\
\ @brief SYSCFG FMC retiming logic control register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_FMC_RETIMECR_CFG_RETIME_RX         \ Retiming on Rx path
$00000002 constant SYSCFG_SYSCFG_FMC_RETIMECR_CFG_RETIME_TX         \ Retiming on Tx path
$00000004 constant SYSCFG_SYSCFG_FMC_RETIMECR_SDFBCLK_180           \ Delay on feedback clock


\
\ @brief SYSCFG NPU RAM interleaving control register
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_NPU_ICNCR_INTERLEAVING_ACTIVE      \ Control interleaving on NPU RAMs


\
\ @brief SYSCFG boot pin status register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_BOOTSR_BOOT0                       \ BOOT0 pin value
$00000002 constant SYSCFG_SYSCFG_BOOTSR_BOOT1                       \ BOOT1 pin value


\
\ @brief SYSCFG AHB write posting address error register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000000 constant SYSCFG_SYSCFG_AHBWP_ERROR_SR_PAHB_ERROR_ADDR     \ Reports address of the first error in P-AHB write-posting buffer


\
\ @brief SYSCFG SMPS observable signals through HDP selection configuration register
\ Address offset: 0x400
\ Reset value: 0x00000000
\

$0000000f constant SYSCFG_SYSCFG_SMPSHDPCR_SMPSHDPSEL               \ Others: Reserved


\
\ @brief SYSCFG DMA CID non-secure control register
\ Address offset: 0x800
\ Reset value: 0x00000001
\

$00000007 constant SYSCFG_SYSCFG_NONSEC_AIDCR_DMACID_NONSEC         \ Non-secure OS allocates specific CID to DMA channel through these bits


\
\ @brief System configuration controller
\
$46008000 constant SYSCFG_SYSCFG_BOOTCR  \ offset: 0x00 : SYSCFG boot pin control register
$46008004 constant SYSCFG_SYSCFG_CM55CR  \ offset: 0x04 : SYSCFG Cortex-M55 control register
$46008008 constant SYSCFG_SYSCFG_CM55TCMCR  \ offset: 0x08 : SYSCFG Cortex-M55 TCM control register
$4600800c constant SYSCFG_SYSCFG_CM55RWMCR  \ offset: 0x0C : SYSCFG Cortex-CM55 memory RW margin register
$46008010 constant SYSCFG_SYSCFG_INITSVTORCR  \ offset: 0x10 : SYSCFG Cortex-M55 SVTOR control register
$46008014 constant SYSCFG_SYSCFG_INITNSVTORCR  \ offset: 0x14 : SYSCFG Cortex-M55 NSVTOR control register
$46008018 constant SYSCFG_SYSCFG_CM55RSTCR  \ offset: 0x18 : SYSCFG Cortex-M55 reset type control register
$4600801c constant SYSCFG_SYSCFG_CM55PAHBWPR  \ offset: 0x1C : SYSCFG Cortex-M55 P-AHB write posting control register
$46008020 constant SYSCFG_SYSCFG_VENCRAMCR  \ offset: 0x20 : SYSCFG VENCRAM control register
$46008024 constant SYSCFG_SYSCFG_POTTAMPRSTCR  \ offset: 0x24 : SYSCFG potential tamper reset register
$46008034 constant SYSCFG_SYSCFG_ICNEWRCR  \ offset: 0x34 : SYSCFG AHB-AXI bridge early write response control register
$46008038 constant SYSCFG_SYSCFG_ICNCGCR  \ offset: 0x38 : SYSCFG ICN clock gating control register
$4600803c constant SYSCFG_SYSCFG_ICNBWRCR  \ offset: 0x3C : SYSCFG ICN bandwidth regulator control register
$46008040 constant SYSCFG_SYSCFG_IOCR  \ offset: 0x40 : SYSCFG /O control register
$46008044 constant SYSCFG_SYSCFG_VDDIO1CCCR  \ offset: 0x44 : SYSCFG VDDIO1 compensation cell control register
$46008048 constant SYSCFG_SYSCFG_VDDIO1CCSR  \ offset: 0x48 : SYSCFG VDDIO1 compensation cell status register
$4600804c constant SYSCFG_SYSCFG_VDDIO2CCCR  \ offset: 0x4C : SYSCFG VDDIO2 compensation cell control register
$46008050 constant SYSCFG_SYSCFG_VDDIO2CCSR  \ offset: 0x50 : SYSCFG VDDIO2 compensation cell status register
$46008054 constant SYSCFG_SYSCFG_VDDIO3CCCR  \ offset: 0x54 : SYSCFG VDDIO3 compensation cell control register
$46008058 constant SYSCFG_SYSCFG_VDDIO3CCSR  \ offset: 0x58 : SYSCFG VDDIO3 compensation cell status register
$4600805c constant SYSCFG_SYSCFG_VDDIO4CCCR  \ offset: 0x5C : SYSCFG VDDIO4 compensation cell control register
$46008060 constant SYSCFG_SYSCFG_VDDIO4CCSR  \ offset: 0x60 : SYSCFG VDDIO4 compensation cell status register
$46008064 constant SYSCFG_SYSCFG_VDDIOCCCR  \ offset: 0x64 : SYSCFG VDDIO compensation cell control register
$46008068 constant SYSCFG_SYSCFG_VDDIOCCSR  \ offset: 0x68 : SYSCFG VDDIO compensation cell status register
$4600806c constant SYSCFG_SYSCFG_CBR  \ offset: 0x6C : SYSCFG control timer break register
$46008070 constant SYSCFG_SYSCFG_SEC_AIDCR  \ offset: 0x70 : SYSCFG DMA CID secure control register
$46008074 constant SYSCFG_SYSCFG_FMC_RETIMECR  \ offset: 0x74 : SYSCFG FMC retiming logic control register
$46008078 constant SYSCFG_SYSCFG_NPU_ICNCR  \ offset: 0x78 : SYSCFG NPU RAM interleaving control register
$46008100 constant SYSCFG_SYSCFG_BOOTSR  \ offset: 0x100 : SYSCFG boot pin status register
$46008104 constant SYSCFG_SYSCFG_AHBWP_ERROR_SR  \ offset: 0x104 : SYSCFG AHB write posting address error register
$46008400 constant SYSCFG_SYSCFG_SMPSHDPCR  \ offset: 0x400 : SYSCFG SMPS observable signals through HDP selection configuration register
$46008800 constant SYSCFG_SYSCFG_NONSEC_AIDCR  \ offset: 0x800 : SYSCFG DMA CID non-secure control register

