\
\ @file sbs.fs
\ @brief System configuration, boot and security
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief SBS boot status register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000000 constant SBS_SBS_BOOTSR_INITVTOR                          \ initial vector for Cortex-M7 This register includes the physical boot address used by the Cortex-M7 after reset


\
\ @brief SBS hide protection control register
\ Address offset: 0x10
\ Reset value: 0x000000B4
\

$000000ff constant SBS_SBS_HDPLCR_INCR_HDPL                         \ increment HDPL Write 0x6A to increment device HDPL by one. After a write, the register value reverts to its default value (0xB4).


\
\ @brief SBS hide protection status register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$000000ff constant SBS_SBS_HDPLSR_HDPL                              \ hide protection level This bitfield returns the current HDPL of the device. 0x6F and other codes: HDPL3, corresponding to non-boot application. Note: The device state (open/close) is defined in FLASH_NVSTATER register of the embedded Flash memory.


\
\ @brief SBS debug control register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$000000ff constant SBS_SBS_DBGCR_AP_UNLOCK                          \ access port unlock Write 0xB4 to this bitfield to open the device access port.
$0000ff00 constant SBS_SBS_DBGCR_DBG_UNLOCK                         \ debug unlock Write 0xB4 to this bitfield to open the debug when HDPL in SBS_HDPLSR equals to DBG_AUTH_HDPL in this register.
$00ff0000 constant SBS_SBS_DBGCR_DBG_AUTH_HDPL                      \ authenticated debug hide protection level Writing to this bitfield defines at which HDPL the authenticated debug opens. Note: Writing any other values is ignored. Reading any other value means the authenticated debug always fails.


\
\ @brief SBS debug lock register
\ Address offset: 0x24
\ Reset value: 0x000000B4
\

$000000ff constant SBS_SBS_DBGLOCKR_DBGCFG_LOCK                     \ debug configuration lock Reading this bitfield returns 0x6A if the bitfield value is different from 0xB4. Other: Writes to SBS_DBGCR ignored Note: 0xC3 is the recommended value to lock the debug configuration using this bitfield.


\
\ @brief SBS RSS command register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant SBS_SBS_RSSCMDR_RSSCMD                           \ RSS command The application can use this bitfield to pass on a command to the RSS, executed at the next reset.


\
\ @brief SBS product mode and configuration register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000010 constant SBS_SBS_PMCR_FMPLUS_PB6                          \ Fast-mode Plus on PB(6)
$00000020 constant SBS_SBS_PMCR_FMPLUS_PB7                          \ Fast-mode Plus on PB(7)
$00000040 constant SBS_SBS_PMCR_FMPLUS_PB8                          \ Fast-mode Plus on PB(8)
$00000080 constant SBS_SBS_PMCR_FMPLUS_PB9                          \ Fast-mode Plus on PB(9)
$00000100 constant SBS_SBS_PMCR_BOOSTEN                             \ booster enable Set this bit to reduce the THD of the analog switches when the supply voltage is below 2.7 V. guaranteeing the same performance as with the full voltage range. To avoid current consumption due to booster activation when V<sub>DDA</sub> < 2.7 V and V<sub>DD</sub> > 2.7 V, V<sub>DD</sub> can be selected as supply voltage for analog switches by setting BOOSTVDDSEL bit in SBS_PMCR. In this case, the BOOSTEN bit must be cleared to avoid unwanted power consumption.
$00000200 constant SBS_SBS_PMCR_BOOSTVDDSEL                         \ booster V<sub>DD</sub> selection This bit selects the analog switch supply voltage, between V<sub>DD</sub>, V<sub>DDA</sub> and booster. To avoid current consumption due to booster activation when V<sub>DDA</sub> < 2.7 V and V<sub>DD</sub> > 2.7 V, V<sub>DD</sub> can be selected as supply voltage for analog switches. In this case, the BOOSTEN bit must be cleared to avoid unwanted power consumption. When both V<sub>DD and </sub>V<sub>DDA</sub> are below 2.7 V, the booster is still needed to obtain full AC performances from the I/O analog switches.
$00e00000 constant SBS_SBS_PMCR_ETH_PHYSEL                          \ Ethernet PHY interface selection Other: reserved
$10000000 constant SBS_SBS_PMCR_AXIRAM_WS                           \ AXIRAM wait state Set this bit to add one wait state to all AXIRAMs when ECC = 0. When ECC = 1 there is one wait state by default.


\
\ @brief SBS FPU interrupt mask register
\ Address offset: 0x104
\ Reset value: 0x0000001F
\

$0000003f constant SBS_SBS_FPUIMR_FPU_IE                            \ FPU interrupt enable Set and cleared by software to enable the Cortex-M7 FPU interrupts xxxxx1: Invalid operation interrupt enabled (xxxxx0 to disable) xxxx1x: Divide-by-zero interrupt enabled (xxxx0x to disable) xxx1xx: Underflow interrupt enabled (xxx0xx to disable) xx1xxx: Overflow interrupt enabled (xx0xxx to disable) x1xxxx: Input denormal interrupt enabled (x0xxxx to disable) 1xxxxx: Inexact interrupt enabled (0xxxxx to disable), disabled by default


\
\ @brief SBS memory erase status register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000001 constant SBS_SBS_MESR_MEF                                 \ memory erase flag This bit is set by hardware when BKPRAM and PKA SRAM erase is ongoing after a POWER ON reset or one tamper event (see Section 50: Tamper and backup registers (TAMP) for details). This bit is cleared when the erase is done.


\
\ @brief SBS I/O compensation cell control and status register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000001 constant SBS_SBS_CCCSR_COMP_EN                            \ Compensation cell enable Set this bit to enable the compensation cell.
$00000002 constant SBS_SBS_CCCSR_COMP_CODESEL                       \ Compensation cell code selection This bit selects the code to be applied for the I/O compensation cell.
$00000004 constant SBS_SBS_CCCSR_OCTO1_COMP_EN                      \ XSPIM_P1 compensation cell enable Set this bit to enable the XSPIM_P1 compensation cell.
$00000008 constant SBS_SBS_CCCSR_OCTO1_COMP_CODESEL                 \ XSPIM_P1 compensation cell code selection This bit selects the code to be applied for the XSPIM_P1 I/O compensation cell.
$00000010 constant SBS_SBS_CCCSR_OCTO2_COMP_EN                      \ XSPIM_P2 compensation cell enable Set this bit to enable the XSPIM_P2 compensation cell.
$00000020 constant SBS_SBS_CCCSR_OCTO2_COMP_CODESEL                 \ XSPIM_P2 compensation cell code selection This bit selects the code to be applied for the XSPIM_P2 I/O compensation cell.
$00000100 constant SBS_SBS_CCCSR_COMP_RDY                           \ Compensation cell ready This bit provides the status of the compensation cell.
$00000200 constant SBS_SBS_CCCSR_OCTO1_COMP_RDY                     \ XSPIM_P1 compensation cell ready This bit provides the status of the XSPIM_P1 compensation cell.
$00000400 constant SBS_SBS_CCCSR_OCTO2_COMP_RDY                     \ XSPIM_P2 compensation cell ready This bit provides the status of the XSPIM_P2 compensation cell.
$00010000 constant SBS_SBS_CCCSR_IOHSLV                             \ I/O high speed at low voltage When this bit is set, the speed of the I/Os is optimized when the device voltage is low. This bit is active only if VDDIO_HSLV user option bit is set in FLASH. It must be used only if the device supply voltage is below 2.7 V. Setting this bit when V<sub>DD</sub> is higher than 2.7 V may be destructive.
$00020000 constant SBS_SBS_CCCSR_OCTO1_IOHSLV                       \ XSPIM_P1 I/O high speed at low voltage When this bit is set, the speed of the XSPIM_P1 I/Os is optimized when the device voltage is low. This bit is active only if OCTO1_HSLV user option bit is set in FLASH. This bit must be used only if the device supply voltage is below 2.7 V. Setting this bit when V<sub>DD</sub> is higher than 2.7 V may be destructive.
$00040000 constant SBS_SBS_CCCSR_OCTO2_IOHSLV                       \ XSPIM_P2 I/O high speed at low voltage When this bit is set, the speed of the XSPIM_P2 I/Os is optimized when the device voltage is low. This bit is active only if OCTO2_HSLV user option bit is set in FLASH. This bit must be used only if the device supply voltage is below 2.7 V. Setting this bit when V<sub>DD</sub> is higher than 2.7 V may be destructive.


\
\ @brief SBS compensation cell for I/Os value register
\ Address offset: 0x114
\ Reset value: 0x00000088
\

$0000000f constant SBS_SBS_CCVALR_NSRC                              \ NMOS transistors slew-rate compensation This bitfield returns the NMOS transistors slew-rate compensation value computed by the cell. It is interpreted to compensate the NMOS transistors slew rate in the functional range if COMP_CODESEL = 0 in SBS_CCCSR register.
$000000f0 constant SBS_SBS_CCVALR_PSRC                              \ PMOS transistors slew-rate compensation This bitfield returns the PMOS transistors slew-rate compensation value computed by the cell. It is interpreted to compensate the PMOS transistors slew rate in the functional range if COMP_CODESEL = 0 in SBS_CCCSR register.
$00000f00 constant SBS_SBS_CCVALR_OCTO1_NSRC                        \ XSPIM_P1 NMOS transistors slew-rate compensation This bitfield returns the NMOS transistors slew-rate compensation value computed by the cell. It is interpreted by XSPIM_P1 to compensate the NMOS transistors slew rate in the functional range if OCTO1_COMP_CODESEL = 0 in SBS_CCCSR register.
$0000f000 constant SBS_SBS_CCVALR_OCTO1_PSRC                        \ XSPIM_P1 PMOS transistors slew-rate compensation This bitfield returns the PMOS transistors slew-rate compensation value computed by the cell. It is interpreted by XSPIM_P1 to compensate the PMOS transistors slew rate in the functional range if OCTO1_COMP_CODESEL = 0 in SBS_CCCSR register.
$000f0000 constant SBS_SBS_CCVALR_OCTO2_NSRC                        \ XSPIM_P2 NMOS transistors slew-rate compensation This bitfield returns the NMOS transistors slew-rate compensation value computed by the cell. It is interpreted by XSPIM_P2 to compensate the NMOS transistors slew rate in the functional range if OCTO2_COMP_CODESEL = 0 in SBS_CCCSR register.
$00f00000 constant SBS_SBS_CCVALR_OCTO2_PSRC                        \ XSPIM_P2 PMOS transistors slew-rate compensation This bitfield returns the PMOS transistors slew-rate compensation value computed by the cell. It is interpreted by XSPIM_P2 to compensate the PMOS transistors slew rate in the functional range if OCTO2_COMP_CODESEL = 0 in SBS_CCCSR register.


\
\ @brief SBS compensation cell for I/Os software value register
\ Address offset: 0x118
\ Reset value: 0x00000088
\

$0000000f constant SBS_SBS_CCSWVALR_SW_NSRC                         \ Software NMOS transistors slew-rate compensation This bitfield returns the NMOS transistors slew-rate compensation value computed by the cell. It is interpreted to compensate the NMOS transistors slew rate in the functional range if COMP_CODESEL = 1 in SBS_CCCSR register.
$000000f0 constant SBS_SBS_CCSWVALR_SW_PSRC                         \ Software PMOS transistors slew-rate compensation This bitfield returns the PMOS transistors slew-rate compensation value computed by the cell. It is interpreted to compensate the PMOS transistors slew rate in the functional range if COMP_CODESEL = 1 in SBS_CCCSR register.
$00000f00 constant SBS_SBS_CCSWVALR_OCTO1_SW_NSRC                   \ XSPIM_P1 software NMOS transistors slew-rate compensation This bitfield returns the NMOS transistors slew -ate compensation value computed by the cell. It is interpreted by XSPIM_P1 to compensate the NMOS transistors slew rate in the functional range if OCTO1_COMP_CODESEL = 1 in SBS_CCCSR register.
$0000f000 constant SBS_SBS_CCSWVALR_OCTO1_SW_PSRC                   \ XSPIM_P1 software PMOS transistors slew-rate compensation This bitfield returns the PMOS transistors slew-rate compensation value computed by the cell. It is interpreted by XSPIM_P1 to compensate the PMOS transistors slew rate in the functional range if OCTO1_COMP_CODESEL = 1 in SBS_CCCSR register.
$000f0000 constant SBS_SBS_CCSWVALR_OCTO2_SW_NSRC                   \ XSPIM_P2 software NMOS transistors slew-rate compensation This bitfield returns the NMOS transistors slew-rate compensation value computed by the cell. It is interpreted by XSPIM_P2 to compensate the NMOS transistors slew rate in the functional range if OCTO2_COMP_CODESEL = 1 in SBS_CCCSR register.
$00f00000 constant SBS_SBS_CCSWVALR_OCTO2_SW_PSRC                   \ XSPIM_P2 software PMOS transistors slew-rate compensation This bitfield returns the PMOS transistors slew-rate compensation value computed by the cell. It is interpreted by XSPIM_P2 to compensate the PMOS transistors slew rate in the functional range if OCTO2_COMP_CODESEL = 1 in SBS_CCCSR register.


\
\ @brief SBS break lockup register
\ Address offset: 0x120
\ Reset value: 0x00000088
\

$00000004 constant SBS_SBS_BKLOCKR_PVD_BL                           \ PVD break lock This bit is set by SW and cleared only by a system reset. it can be used to enable and lock the connection to TIM1/8/15/16/17Break input as well as the PVDE and PLS[2:0] bitfields in the PWR_CR1 register. Once set, this bit is cleared only by a system reset.
$00000008 constant SBS_SBS_BKLOCKR_FLASHECC_BL                      \ Flash ECC error break lock Set this bit to enable and lock the connection between embedded flash memory ECC double error detection flag and break inputs of TIM1/15/16/17 peripherals. Once set, this bit is cleared only by a system reset.
$00000040 constant SBS_SBS_BKLOCKR_CM7LCKUP_BL                      \ Cortex-M7 lockup break lock Set this bit to enable and lock the connection between the Cortex-M7 lockup (HardFault) output and break inputs of TIM1/15/16/17 peripherals. Once set, this bit is cleared only by a system reset.
$00000080 constant SBS_SBS_BKLOCKR_BKRAMECC_BL                      \ Backup RAM ECC error break lock Set this bit to enable and lock the connection between backup RAM ECC double error detection flag and break inputs of TIM1/15/16/17 peripherals. Once set, this bit is cleared only by a system reset.
$00002000 constant SBS_SBS_BKLOCKR_DTCMECC_BL                       \ DTCM ECC error break lock Set this bit to enable and lock the connection between DTCM ECC double error detection flag and break inputs of TIM1/15/16/17 peripherals. Once set, this bit is cleared only by a system reset. Note: The DTCM0 and DTCM1 are Ored to give DTCMECC
$00004000 constant SBS_SBS_BKLOCKR_ITCMECC_BL                       \ ITCM ECC error break lock Set this bit to enable and lock the connection between ITCM ECC double error detection flag and break inputs of TIM1/15/16/17 peripherals. Once set, this bit is cleared only by a system reset.
$00200000 constant SBS_SBS_BKLOCKR_ARAM3ECC_BL                      \ AXIRAM3 ECC error break lock Set this bit to enable and lock the connection between AXIRAM3 ECC double error detection flag and break inputs of TIM1/15/16/17 peripherals. Once set this bit is cleared only by a system reset.
$00800000 constant SBS_SBS_BKLOCKR_ARAM1ECC_BL                      \ AXIRAM1 ECC error break lock Set this bit to enable and lock the connection between AXIRAM1 ECC double error detection flag and break inputs of TIM1/15/16/17 peripherals. Once set, this bit is cleared only by a system reset.


\
\ @brief SBS external interrupt configuration register 0
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$0000000f constant SBS_SBS_EXTICR0_PC_EXTI0                         \ Port configuration EXTI {0 * 4 + i} This bitfield selects the source input to the EXTI input {0 * 4 + i} used for external interrupt/ event detection. Others: reserved
$000000f0 constant SBS_SBS_EXTICR0_PC_EXTI1                         \ Port configuration EXTI {0 * 4 + i} This bitfield selects the source input to the EXTI input {0 * 4 + i} used for external interrupt/ event detection. Others: reserved
$00000f00 constant SBS_SBS_EXTICR0_PC_EXTI2                         \ Port configuration EXTI {0 * 4 + i} This bitfield selects the source input to the EXTI input {0 * 4 + i} used for external interrupt/ event detection. Others: reserved
$0000f000 constant SBS_SBS_EXTICR0_PC_EXTI3                         \ Port configuration EXTI {0 * 4 + i} This bitfield selects the source input to the EXTI input {0 * 4 + i} used for external interrupt/ event detection. Others: reserved


\
\ @brief SBS external interrupt configuration register 1
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$0000000f constant SBS_SBS_EXTICR1_PC_EXTI4                         \ Port configuration EXTI {1 * 4 + i} This bitfield selects the source input to the EXTI input {1 * 4 + i} used for external interrupt/ event detection. Others: reserved
$000000f0 constant SBS_SBS_EXTICR1_PC_EXTI5                         \ Port configuration EXTI {1 * 4 + i} This bitfield selects the source input to the EXTI input {1 * 4 + i} used for external interrupt/ event detection. Others: reserved
$00000f00 constant SBS_SBS_EXTICR1_PC_EXTI6                         \ Port configuration EXTI {1 * 4 + i} This bitfield selects the source input to the EXTI input {1 * 4 + i} used for external interrupt/ event detection. Others: reserved
$0000f000 constant SBS_SBS_EXTICR1_PC_EXTI7                         \ Port configuration EXTI {1 * 4 + i} This bitfield selects the source input to the EXTI input {1 * 4 + i} used for external interrupt/ event detection. Others: reserved


\
\ @brief SBS external interrupt configuration register 2
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$0000000f constant SBS_SBS_EXTICR2_PC_EXTI8                         \ Port configuration EXTI {2 * 4 + i} This bitfield selects the source input to the EXTI input {2 * 4 + i} used for external interrupt/ event detection. Others: reserved
$000000f0 constant SBS_SBS_EXTICR2_PC_EXTI9                         \ Port configuration EXTI {2 * 4 + i} This bitfield selects the source input to the EXTI input {2 * 4 + i} used for external interrupt/ event detection. Others: reserved
$00000f00 constant SBS_SBS_EXTICR2_PC_EXTI10                        \ Port configuration EXTI {2 * 4 + i} This bitfield selects the source input to the EXTI input {2 * 4 + i} used for external interrupt/ event detection. Others: reserved
$0000f000 constant SBS_SBS_EXTICR2_PC_EXTI11                        \ Port configuration EXTI {2 * 4 + i} This bitfield selects the source input to the EXTI input {2 * 4 + i} used for external interrupt/ event detection. Others: reserved


\
\ @brief SBS external interrupt configuration register 3
\ Address offset: 0x13C
\ Reset value: 0x00000000
\

$0000000f constant SBS_SBS_EXTICR3_PC_EXTI12                        \ Port configuration EXTI {3 * 4 + i} This bitfield selects the source input to the EXTI input {3 * 4 + i} used for external interrupt/ event detection. Others: reserved
$000000f0 constant SBS_SBS_EXTICR3_PC_EXTI13                        \ Port configuration EXTI {3 * 4 + i} This bitfield selects the source input to the EXTI input {3 * 4 + i} used for external interrupt/ event detection. Others: reserved
$00000f00 constant SBS_SBS_EXTICR3_PC_EXTI14                        \ Port configuration EXTI {3 * 4 + i} This bitfield selects the source input to the EXTI input {3 * 4 + i} used for external interrupt/ event detection. Others: reserved
$0000f000 constant SBS_SBS_EXTICR3_PC_EXTI15                        \ Port configuration EXTI {3 * 4 + i} This bitfield selects the source input to the EXTI input {3 * 4 + i} used for external interrupt/ event detection. Others: reserved


\
\ @brief System configuration, boot and security
\
$58000400 constant SBS_SBS_BOOTSR  \ offset: 0x00 : SBS boot status register
$58000410 constant SBS_SBS_HDPLCR  \ offset: 0x10 : SBS hide protection control register
$58000414 constant SBS_SBS_HDPLSR  \ offset: 0x14 : SBS hide protection status register
$58000420 constant SBS_SBS_DBGCR  \ offset: 0x20 : SBS debug control register
$58000424 constant SBS_SBS_DBGLOCKR  \ offset: 0x24 : SBS debug lock register
$58000434 constant SBS_SBS_RSSCMDR  \ offset: 0x34 : SBS RSS command register
$58000500 constant SBS_SBS_PMCR   \ offset: 0x100 : SBS product mode and configuration register
$58000504 constant SBS_SBS_FPUIMR  \ offset: 0x104 : SBS FPU interrupt mask register
$58000508 constant SBS_SBS_MESR   \ offset: 0x108 : SBS memory erase status register
$58000510 constant SBS_SBS_CCCSR  \ offset: 0x110 : SBS I/O compensation cell control and status register
$58000514 constant SBS_SBS_CCVALR  \ offset: 0x114 : SBS compensation cell for I/Os value register
$58000518 constant SBS_SBS_CCSWVALR  \ offset: 0x118 : SBS compensation cell for I/Os software value register
$58000520 constant SBS_SBS_BKLOCKR  \ offset: 0x120 : SBS break lockup register
$58000530 constant SBS_SBS_EXTICR0  \ offset: 0x130 : SBS external interrupt configuration register 0
$58000534 constant SBS_SBS_EXTICR1  \ offset: 0x134 : SBS external interrupt configuration register 1
$58000538 constant SBS_SBS_EXTICR2  \ offset: 0x138 : SBS external interrupt configuration register 2
$5800053c constant SBS_SBS_EXTICR3  \ offset: 0x13C : SBS external interrupt configuration register 3

