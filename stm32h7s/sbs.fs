\
\ @file sbs.fs
\ @brief System configuration, boot and security
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SBS_DEF

  [ifdef] SBS_SBS_BOOTSR_DEF
    \
    \ @brief SBS boot status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SBS_INITVTOR                   \ [0x00 : 32] initial vector for Cortex-M7 This register includes the physical boot address used by the Cortex-M7 after reset
  [then]


  [ifdef] SBS_SBS_HDPLCR_DEF
    \
    \ @brief SBS hide protection control register
    \ Address offset: 0x10
    \ Reset value: 0x000000B4
    \
    $00 constant SBS_INCR_HDPL                  \ [0x00 : 8] increment HDPL Write 0x6A to increment device HDPL by one. After a write, the register value reverts to its default value (0xB4).
  [then]


  [ifdef] SBS_SBS_HDPLSR_DEF
    \
    \ @brief SBS hide protection status register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant SBS_HDPL                       \ [0x00 : 8] hide protection level This bitfield returns the current HDPL of the device. 0x6F and other codes: HDPL3, corresponding to non-boot application. Note: The device state (open/close) is defined in FLASH_NVSTATER register of the embedded Flash memory.
  [then]


  [ifdef] SBS_SBS_DBGCR_DEF
    \
    \ @brief SBS debug control register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant SBS_AP_UNLOCK                  \ [0x00 : 8] access port unlock Write 0xB4 to this bitfield to open the device access port.
    $08 constant SBS_DBG_UNLOCK                 \ [0x08 : 8] debug unlock Write 0xB4 to this bitfield to open the debug when HDPL in SBS_HDPLSR equals to DBG_AUTH_HDPL in this register.
    $10 constant SBS_DBG_AUTH_HDPL              \ [0x10 : 8] authenticated debug hide protection level Writing to this bitfield defines at which HDPL the authenticated debug opens. Note: Writing any other values is ignored. Reading any other value means the authenticated debug always fails.
  [then]


  [ifdef] SBS_SBS_DBGLOCKR_DEF
    \
    \ @brief SBS debug lock register
    \ Address offset: 0x24
    \ Reset value: 0x000000B4
    \
    $00 constant SBS_DBGCFG_LOCK                \ [0x00 : 8] debug configuration lock Reading this bitfield returns 0x6A if the bitfield value is different from 0xB4. Other: Writes to SBS_DBGCR ignored Note: 0xC3 is the recommended value to lock the debug configuration using this bitfield.
  [then]


  [ifdef] SBS_SBS_RSSCMDR_DEF
    \
    \ @brief SBS RSS command register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant SBS_RSSCMD                     \ [0x00 : 16] RSS command The application can use this bitfield to pass on a command to the RSS, executed at the next reset.
  [then]


  [ifdef] SBS_SBS_PMCR_DEF
    \
    \ @brief SBS product mode and configuration register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $04 constant SBS_FMPLUS_PB6                 \ [0x04] Fast-mode Plus on PB(6)
    $05 constant SBS_FMPLUS_PB7                 \ [0x05] Fast-mode Plus on PB(7)
    $06 constant SBS_FMPLUS_PB8                 \ [0x06] Fast-mode Plus on PB(8)
    $07 constant SBS_FMPLUS_PB9                 \ [0x07] Fast-mode Plus on PB(9)
    $08 constant SBS_BOOSTEN                    \ [0x08] booster enable Set this bit to reduce the THD of the analog switches when the supply voltage is below 2.7 V. guaranteeing the same performance as with the full voltage range. To avoid current consumption due to booster activation when V<sub>DDA</sub> < 2.7 V and V<sub>DD</sub> > 2.7 V, V<sub>DD</sub> can be selected as supply voltage for analog switches by setting BOOSTVDDSEL bit in SBS_PMCR. In this case, the BOOSTEN bit must be cleared to avoid unwanted power consumption.
    $09 constant SBS_BOOSTVDDSEL                \ [0x09] booster V<sub>DD</sub> selection This bit selects the analog switch supply voltage, between V<sub>DD</sub>, V<sub>DDA</sub> and booster. To avoid current consumption due to booster activation when V<sub>DDA</sub> < 2.7 V and V<sub>DD</sub> > 2.7 V, V<sub>DD</sub> can be selected as supply voltage for analog switches. In this case, the BOOSTEN bit must be cleared to avoid unwanted power consumption. When both V<sub>DD and </sub>V<sub>DDA</sub> are below 2.7 V, the booster is still needed to obtain full AC performances from the I/O analog switches.
    $15 constant SBS_ETH_PHYSEL                 \ [0x15 : 3] Ethernet PHY interface selection Other: reserved
    $1c constant SBS_AXIRAM_WS                  \ [0x1c] AXIRAM wait state Set this bit to add one wait state to all AXIRAMs when ECC = 0. When ECC = 1 there is one wait state by default.
  [then]


  [ifdef] SBS_SBS_FPUIMR_DEF
    \
    \ @brief SBS FPU interrupt mask register
    \ Address offset: 0x104
    \ Reset value: 0x0000001F
    \
    $00 constant SBS_FPU_IE                     \ [0x00 : 6] FPU interrupt enable Set and cleared by software to enable the Cortex-M7 FPU interrupts xxxxx1: Invalid operation interrupt enabled (xxxxx0 to disable) xxxx1x: Divide-by-zero interrupt enabled (xxxx0x to disable) xxx1xx: Underflow interrupt enabled (xxx0xx to disable) xx1xxx: Overflow interrupt enabled (xx0xxx to disable) x1xxxx: Input denormal interrupt enabled (x0xxxx to disable) 1xxxxx: Inexact interrupt enabled (0xxxxx to disable), disabled by default
  [then]


  [ifdef] SBS_SBS_MESR_DEF
    \
    \ @brief SBS memory erase status register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant SBS_MEF                        \ [0x00] memory erase flag This bit is set by hardware when BKPRAM and PKA SRAM erase is ongoing after a POWER ON reset or one tamper event (see Section 50: Tamper and backup registers (TAMP) for details). This bit is cleared when the erase is done.
  [then]


  [ifdef] SBS_SBS_CCCSR_DEF
    \
    \ @brief SBS I/O compensation cell control and status register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant SBS_COMP_EN                    \ [0x00] Compensation cell enable Set this bit to enable the compensation cell.
    $01 constant SBS_COMP_CODESEL               \ [0x01] Compensation cell code selection This bit selects the code to be applied for the I/O compensation cell.
    $02 constant SBS_OCTO1_COMP_EN              \ [0x02] XSPIM_P1 compensation cell enable Set this bit to enable the XSPIM_P1 compensation cell.
    $03 constant SBS_OCTO1_COMP_CODESEL         \ [0x03] XSPIM_P1 compensation cell code selection This bit selects the code to be applied for the XSPIM_P1 I/O compensation cell.
    $04 constant SBS_OCTO2_COMP_EN              \ [0x04] XSPIM_P2 compensation cell enable Set this bit to enable the XSPIM_P2 compensation cell.
    $05 constant SBS_OCTO2_COMP_CODESEL         \ [0x05] XSPIM_P2 compensation cell code selection This bit selects the code to be applied for the XSPIM_P2 I/O compensation cell.
    $08 constant SBS_COMP_RDY                   \ [0x08] Compensation cell ready This bit provides the status of the compensation cell.
    $09 constant SBS_OCTO1_COMP_RDY             \ [0x09] XSPIM_P1 compensation cell ready This bit provides the status of the XSPIM_P1 compensation cell.
    $0a constant SBS_OCTO2_COMP_RDY             \ [0x0a] XSPIM_P2 compensation cell ready This bit provides the status of the XSPIM_P2 compensation cell.
    $10 constant SBS_IOHSLV                     \ [0x10] I/O high speed at low voltage When this bit is set, the speed of the I/Os is optimized when the device voltage is low. This bit is active only if VDDIO_HSLV user option bit is set in FLASH. It must be used only if the device supply voltage is below 2.7 V. Setting this bit when V<sub>DD</sub> is higher than 2.7 V may be destructive.
    $11 constant SBS_OCTO1_IOHSLV               \ [0x11] XSPIM_P1 I/O high speed at low voltage When this bit is set, the speed of the XSPIM_P1 I/Os is optimized when the device voltage is low. This bit is active only if OCTO1_HSLV user option bit is set in FLASH. This bit must be used only if the device supply voltage is below 2.7 V. Setting this bit when V<sub>DD</sub> is higher than 2.7 V may be destructive.
    $12 constant SBS_OCTO2_IOHSLV               \ [0x12] XSPIM_P2 I/O high speed at low voltage When this bit is set, the speed of the XSPIM_P2 I/Os is optimized when the device voltage is low. This bit is active only if OCTO2_HSLV user option bit is set in FLASH. This bit must be used only if the device supply voltage is below 2.7 V. Setting this bit when V<sub>DD</sub> is higher than 2.7 V may be destructive.
  [then]


  [ifdef] SBS_SBS_CCVALR_DEF
    \
    \ @brief SBS compensation cell for I/Os value register
    \ Address offset: 0x114
    \ Reset value: 0x00000088
    \
    $00 constant SBS_NSRC                       \ [0x00 : 4] NMOS transistors slew-rate compensation This bitfield returns the NMOS transistors slew-rate compensation value computed by the cell. It is interpreted to compensate the NMOS transistors slew rate in the functional range if COMP_CODESEL = 0 in SBS_CCCSR register.
    $04 constant SBS_PSRC                       \ [0x04 : 4] PMOS transistors slew-rate compensation This bitfield returns the PMOS transistors slew-rate compensation value computed by the cell. It is interpreted to compensate the PMOS transistors slew rate in the functional range if COMP_CODESEL = 0 in SBS_CCCSR register.
    $08 constant SBS_OCTO1_NSRC                 \ [0x08 : 4] XSPIM_P1 NMOS transistors slew-rate compensation This bitfield returns the NMOS transistors slew-rate compensation value computed by the cell. It is interpreted by XSPIM_P1 to compensate the NMOS transistors slew rate in the functional range if OCTO1_COMP_CODESEL = 0 in SBS_CCCSR register.
    $0c constant SBS_OCTO1_PSRC                 \ [0x0c : 4] XSPIM_P1 PMOS transistors slew-rate compensation This bitfield returns the PMOS transistors slew-rate compensation value computed by the cell. It is interpreted by XSPIM_P1 to compensate the PMOS transistors slew rate in the functional range if OCTO1_COMP_CODESEL = 0 in SBS_CCCSR register.
    $10 constant SBS_OCTO2_NSRC                 \ [0x10 : 4] XSPIM_P2 NMOS transistors slew-rate compensation This bitfield returns the NMOS transistors slew-rate compensation value computed by the cell. It is interpreted by XSPIM_P2 to compensate the NMOS transistors slew rate in the functional range if OCTO2_COMP_CODESEL = 0 in SBS_CCCSR register.
    $14 constant SBS_OCTO2_PSRC                 \ [0x14 : 4] XSPIM_P2 PMOS transistors slew-rate compensation This bitfield returns the PMOS transistors slew-rate compensation value computed by the cell. It is interpreted by XSPIM_P2 to compensate the PMOS transistors slew rate in the functional range if OCTO2_COMP_CODESEL = 0 in SBS_CCCSR register.
  [then]


  [ifdef] SBS_SBS_CCSWVALR_DEF
    \
    \ @brief SBS compensation cell for I/Os software value register
    \ Address offset: 0x118
    \ Reset value: 0x00000088
    \
    $00 constant SBS_SW_NSRC                    \ [0x00 : 4] Software NMOS transistors slew-rate compensation This bitfield returns the NMOS transistors slew-rate compensation value computed by the cell. It is interpreted to compensate the NMOS transistors slew rate in the functional range if COMP_CODESEL = 1 in SBS_CCCSR register.
    $04 constant SBS_SW_PSRC                    \ [0x04 : 4] Software PMOS transistors slew-rate compensation This bitfield returns the PMOS transistors slew-rate compensation value computed by the cell. It is interpreted to compensate the PMOS transistors slew rate in the functional range if COMP_CODESEL = 1 in SBS_CCCSR register.
    $08 constant SBS_OCTO1_SW_NSRC              \ [0x08 : 4] XSPIM_P1 software NMOS transistors slew-rate compensation This bitfield returns the NMOS transistors slew -ate compensation value computed by the cell. It is interpreted by XSPIM_P1 to compensate the NMOS transistors slew rate in the functional range if OCTO1_COMP_CODESEL = 1 in SBS_CCCSR register.
    $0c constant SBS_OCTO1_SW_PSRC              \ [0x0c : 4] XSPIM_P1 software PMOS transistors slew-rate compensation This bitfield returns the PMOS transistors slew-rate compensation value computed by the cell. It is interpreted by XSPIM_P1 to compensate the PMOS transistors slew rate in the functional range if OCTO1_COMP_CODESEL = 1 in SBS_CCCSR register.
    $10 constant SBS_OCTO2_SW_NSRC              \ [0x10 : 4] XSPIM_P2 software NMOS transistors slew-rate compensation This bitfield returns the NMOS transistors slew-rate compensation value computed by the cell. It is interpreted by XSPIM_P2 to compensate the NMOS transistors slew rate in the functional range if OCTO2_COMP_CODESEL = 1 in SBS_CCCSR register.
    $14 constant SBS_OCTO2_SW_PSRC              \ [0x14 : 4] XSPIM_P2 software PMOS transistors slew-rate compensation This bitfield returns the PMOS transistors slew-rate compensation value computed by the cell. It is interpreted by XSPIM_P2 to compensate the PMOS transistors slew rate in the functional range if OCTO2_COMP_CODESEL = 1 in SBS_CCCSR register.
  [then]


  [ifdef] SBS_SBS_BKLOCKR_DEF
    \
    \ @brief SBS break lockup register
    \ Address offset: 0x120
    \ Reset value: 0x00000088
    \
    $02 constant SBS_PVD_BL                     \ [0x02] PVD break lock This bit is set by SW and cleared only by a system reset. it can be used to enable and lock the connection to TIM1/8/15/16/17Break input as well as the PVDE and PLS[2:0] bitfields in the PWR_CR1 register. Once set, this bit is cleared only by a system reset.
    $03 constant SBS_FLASHECC_BL                \ [0x03] Flash ECC error break lock Set this bit to enable and lock the connection between embedded flash memory ECC double error detection flag and break inputs of TIM1/15/16/17 peripherals. Once set, this bit is cleared only by a system reset.
    $06 constant SBS_CM7LCKUP_BL                \ [0x06] Cortex-M7 lockup break lock Set this bit to enable and lock the connection between the Cortex-M7 lockup (HardFault) output and break inputs of TIM1/15/16/17 peripherals. Once set, this bit is cleared only by a system reset.
    $07 constant SBS_BKRAMECC_BL                \ [0x07] Backup RAM ECC error break lock Set this bit to enable and lock the connection between backup RAM ECC double error detection flag and break inputs of TIM1/15/16/17 peripherals. Once set, this bit is cleared only by a system reset.
    $0d constant SBS_DTCMECC_BL                 \ [0x0d] DTCM ECC error break lock Set this bit to enable and lock the connection between DTCM ECC double error detection flag and break inputs of TIM1/15/16/17 peripherals. Once set, this bit is cleared only by a system reset. Note: The DTCM0 and DTCM1 are Ored to give DTCMECC
    $0e constant SBS_ITCMECC_BL                 \ [0x0e] ITCM ECC error break lock Set this bit to enable and lock the connection between ITCM ECC double error detection flag and break inputs of TIM1/15/16/17 peripherals. Once set, this bit is cleared only by a system reset.
    $15 constant SBS_ARAM3ECC_BL                \ [0x15] AXIRAM3 ECC error break lock Set this bit to enable and lock the connection between AXIRAM3 ECC double error detection flag and break inputs of TIM1/15/16/17 peripherals. Once set this bit is cleared only by a system reset.
    $17 constant SBS_ARAM1ECC_BL                \ [0x17] AXIRAM1 ECC error break lock Set this bit to enable and lock the connection between AXIRAM1 ECC double error detection flag and break inputs of TIM1/15/16/17 peripherals. Once set, this bit is cleared only by a system reset.
  [then]


  [ifdef] SBS_SBS_EXTICR0_DEF
    \
    \ @brief SBS external interrupt configuration register 0
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant SBS_PC_EXTI0                   \ [0x00 : 4] Port configuration EXTI {0 * 4 + i} This bitfield selects the source input to the EXTI input {0 * 4 + i} used for external interrupt/ event detection. Others: reserved
    $04 constant SBS_PC_EXTI1                   \ [0x04 : 4] Port configuration EXTI {0 * 4 + i} This bitfield selects the source input to the EXTI input {0 * 4 + i} used for external interrupt/ event detection. Others: reserved
    $08 constant SBS_PC_EXTI2                   \ [0x08 : 4] Port configuration EXTI {0 * 4 + i} This bitfield selects the source input to the EXTI input {0 * 4 + i} used for external interrupt/ event detection. Others: reserved
    $0c constant SBS_PC_EXTI3                   \ [0x0c : 4] Port configuration EXTI {0 * 4 + i} This bitfield selects the source input to the EXTI input {0 * 4 + i} used for external interrupt/ event detection. Others: reserved
  [then]


  [ifdef] SBS_SBS_EXTICR1_DEF
    \
    \ @brief SBS external interrupt configuration register 1
    \ Address offset: 0x134
    \ Reset value: 0x00000000
    \
    $00 constant SBS_PC_EXTI4                   \ [0x00 : 4] Port configuration EXTI {1 * 4 + i} This bitfield selects the source input to the EXTI input {1 * 4 + i} used for external interrupt/ event detection. Others: reserved
    $04 constant SBS_PC_EXTI5                   \ [0x04 : 4] Port configuration EXTI {1 * 4 + i} This bitfield selects the source input to the EXTI input {1 * 4 + i} used for external interrupt/ event detection. Others: reserved
    $08 constant SBS_PC_EXTI6                   \ [0x08 : 4] Port configuration EXTI {1 * 4 + i} This bitfield selects the source input to the EXTI input {1 * 4 + i} used for external interrupt/ event detection. Others: reserved
    $0c constant SBS_PC_EXTI7                   \ [0x0c : 4] Port configuration EXTI {1 * 4 + i} This bitfield selects the source input to the EXTI input {1 * 4 + i} used for external interrupt/ event detection. Others: reserved
  [then]


  [ifdef] SBS_SBS_EXTICR2_DEF
    \
    \ @brief SBS external interrupt configuration register 2
    \ Address offset: 0x138
    \ Reset value: 0x00000000
    \
    $00 constant SBS_PC_EXTI8                   \ [0x00 : 4] Port configuration EXTI {2 * 4 + i} This bitfield selects the source input to the EXTI input {2 * 4 + i} used for external interrupt/ event detection. Others: reserved
    $04 constant SBS_PC_EXTI9                   \ [0x04 : 4] Port configuration EXTI {2 * 4 + i} This bitfield selects the source input to the EXTI input {2 * 4 + i} used for external interrupt/ event detection. Others: reserved
    $08 constant SBS_PC_EXTI10                  \ [0x08 : 4] Port configuration EXTI {2 * 4 + i} This bitfield selects the source input to the EXTI input {2 * 4 + i} used for external interrupt/ event detection. Others: reserved
    $0c constant SBS_PC_EXTI11                  \ [0x0c : 4] Port configuration EXTI {2 * 4 + i} This bitfield selects the source input to the EXTI input {2 * 4 + i} used for external interrupt/ event detection. Others: reserved
  [then]


  [ifdef] SBS_SBS_EXTICR3_DEF
    \
    \ @brief SBS external interrupt configuration register 3
    \ Address offset: 0x13C
    \ Reset value: 0x00000000
    \
    $00 constant SBS_PC_EXTI12                  \ [0x00 : 4] Port configuration EXTI {3 * 4 + i} This bitfield selects the source input to the EXTI input {3 * 4 + i} used for external interrupt/ event detection. Others: reserved
    $04 constant SBS_PC_EXTI13                  \ [0x04 : 4] Port configuration EXTI {3 * 4 + i} This bitfield selects the source input to the EXTI input {3 * 4 + i} used for external interrupt/ event detection. Others: reserved
    $08 constant SBS_PC_EXTI14                  \ [0x08 : 4] Port configuration EXTI {3 * 4 + i} This bitfield selects the source input to the EXTI input {3 * 4 + i} used for external interrupt/ event detection. Others: reserved
    $0c constant SBS_PC_EXTI15                  \ [0x0c : 4] Port configuration EXTI {3 * 4 + i} This bitfield selects the source input to the EXTI input {3 * 4 + i} used for external interrupt/ event detection. Others: reserved
  [then]

  \
  \ @brief System configuration, boot and security
  \
  $00 constant SBS_SBS_BOOTSR           \ SBS boot status register
  $10 constant SBS_SBS_HDPLCR           \ SBS hide protection control register
  $14 constant SBS_SBS_HDPLSR           \ SBS hide protection status register
  $20 constant SBS_SBS_DBGCR            \ SBS debug control register
  $24 constant SBS_SBS_DBGLOCKR         \ SBS debug lock register
  $34 constant SBS_SBS_RSSCMDR          \ SBS RSS command register
  $100 constant SBS_SBS_PMCR            \ SBS product mode and configuration register
  $104 constant SBS_SBS_FPUIMR          \ SBS FPU interrupt mask register
  $108 constant SBS_SBS_MESR            \ SBS memory erase status register
  $110 constant SBS_SBS_CCCSR           \ SBS I/O compensation cell control and status register
  $114 constant SBS_SBS_CCVALR          \ SBS compensation cell for I/Os value register
  $118 constant SBS_SBS_CCSWVALR        \ SBS compensation cell for I/Os software value register
  $120 constant SBS_SBS_BKLOCKR         \ SBS break lockup register
  $130 constant SBS_SBS_EXTICR0         \ SBS external interrupt configuration register 0
  $134 constant SBS_SBS_EXTICR1         \ SBS external interrupt configuration register 1
  $138 constant SBS_SBS_EXTICR2         \ SBS external interrupt configuration register 2
  $13C constant SBS_SBS_EXTICR3         \ SBS external interrupt configuration register 3

: SBS_DEF ; [then]
