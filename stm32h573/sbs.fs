\
\ @file sbs.fs
\ @brief SBS register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SBS_DEF

  [ifdef] SBS_SBS_HDPLCR_DEF
    \
    \ @brief SBS temporal isolation control register
    \ Address offset: 0x10
    \ Reset value: 0x000000B4
    \
    $00 constant SBS_INCR_HDPL                  \ [0x00 : 8] increment HDPL value Other: all other values allow a HDPL level increment.
  [then]


  [ifdef] SBS_SBS_HDPLSR_DEF
    \
    \ @brief SBS temporal isolation status register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant SBS_HDPL                       \ [0x00 : 8] temporal isolation level This bitfield returns the current temporal isolation level.
  [then]


  [ifdef] SBS_SBS_NEXTHDPLCR_DEF
    \
    \ @brief SBS next HDPL control register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant SBS_NEXTHDPL                   \ [0x00 : 2] index to point to a higher HDPL than the current one Index to add to the current HDPL to point (through OBK-HDPL) to the next secure storage areas (OBK-HDPL = HDPL + NEXTHDPL). See for more details.
  [then]


  [ifdef] SBS_SBS_DBGCR_DEF
    \
    \ @brief SBS debug control register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant SBS_AP_UNLOCK                  \ [0x00 : 8] access port unlock Write 0xB4 to this bitfield to open the device access port.
    $08 constant SBS_DBG_UNLOCK                 \ [0x08 : 8] debug unlock when DBG_AUTH_HDPL is reached Write 0xB4 to this bitfield to open the debug when HDPL in SBS_HDPLSR equals to DBG_AUTH_HDPL in this register.
    $10 constant SBS_DBG_AUTH_HDPL              \ [0x10 : 8] authenticated debug temporal isolation level Writing to this bitfield defines at which HDPL the authenticated debug opens. Note: Writing any other values is ignored. Reading any other value means the debug never opens.
    $18 constant SBS_DBG_AUTH_SEC               \ [0x18 : 8] control debug opening secure/non-secure Write 0xB4 to this bitfield to open debug for secure and non-secure. Writing any other values only open non-secure.
  [then]


  [ifdef] SBS_SBS_DBGLOCKR_DEF
    \
    \ @brief SBS debug lock register
    \ Address offset: 0x24
    \ Reset value: 0x000000B4
    \
    $00 constant SBS_DBGCFG_LOCK                \ [0x00 : 8] debug configuration lock Reading this bitfield returns 0x6A if the bitfield value is different from 0xB4. 0xC3 is the recommended value to lock the debug configuration using this bitfield. Other: Writes to SBS_DBGCR ignored
  [then]


  [ifdef] SBS_SBS_RSSCMDR_DEF
    \
    \ @brief SBS RSS command register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant SBS_RSSCMD                     \ [0x00 : 16] RSS command The application can use this bitfield to pass on a command to the RSS, executed at the next reset. When RSSCMD different 0 and PRODUCT_STATE is in Open, then the system always boots on RSS whatever is the boot pin value.
  [then]


  [ifdef] SBS_SBS_EPOCHSELCR_DEF
    \
    \ @brief SBS EPOCH selection control register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant SBS_EPOCH_SEL                  \ [0x00 : 2] select EPOCH value to be sent to the SAES 1x: EPOCH forced to zero (value used to retrieve PUF reference value at boot time)
  [then]


  [ifdef] SBS_SBS_SECCFGR_DEF
    \
    \ @brief SBS security mode configuration control register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant SBS_SBSSEC                     \ [0x00] SBS clock control, memory-erase status register and compensation cell register security enable
    $01 constant SBS_CLASSBSEC                  \ [0x01] ClassB security enable
    $03 constant SBS_FPUSEC                     \ [0x03] FPU security enable Note: This bit can only be written through privilege transaction.
    $1f constant SBS_SDCE_SEC_EN                \ [0x1f] control accessibility of SMPS_DIV_CLOCK _EN in SBS_PMCR
  [then]


  [ifdef] SBS_SBS_PMCR_DEF
    \
    \ @brief SBS product mode and configuration register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $08 constant SBS_BOOSTEN                    \ [0x08] booster enable Set this bit to reduce the total harmonic distortion of the analog switch when the processor supply is below 2.7 V. The booster can be activated to guaranty AC performance on analog switch when the supply is below 2.7 V. When the booster is activated, the analog switch performances are the same as with the full voltage range.
    $09 constant SBS_BOOSTVDDSEL                \ [0x09] booster VDD selection Note: Booster must not be used when VDDA 2.7 V, but VDD 2.7 V (add current consumption). When both VDD 2.7 V and VDDA 2.7 V, booster is needed to get full AC performances from I/O analog switches.
    $10 constant SBS_PB6_FMPLUS                 \ [0x10] Fast-mode Plus command on PB(6)
    $11 constant SBS_PB7_FMPLUS                 \ [0x11] Fast-mode Plus command on PB(7)
    $12 constant SBS_PB8_FMPLUS                 \ [0x12] Fast-mode Plus command on PB(8)
    $13 constant SBS_PB9_FMPLUS                 \ [0x13] Fast-mode Plus command on PB(9)
    $15 constant SBS_ETH_SEL_PHY                \ [0x15 : 3] Ethernet PHY interface selection Other: reserved
  [then]


  [ifdef] SBS_SBS_FPUIMR_DEF
    \
    \ @brief SBS FPU interrupt mask register
    \ Address offset: 0x104
    \ Reset value: 0x0000001F
    \
    $00 constant SBS_FPU_IE                     \ [0x00 : 6] FPU interrupt enable Set and cleared by software to enable the Cortex-M33 FPU interrupts FPU_IE[5]: inexact interrupt enable (interrupt disabled at reset) FPU_IE[4]: input abnormal interrupt enable FPU_IE[3]: overflow interrupt enable FPU_IE[2]: underflow interrupt enable FPU_IE[1]: divide-by-zero interrupt enable FPU_IE[0]: invalid operation interrupt enable
  [then]


  [ifdef] SBS_SBS_MESR_DEF
    \
    \ @brief SBS memory erase status register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant SBS_MCLR                       \ [0x00] erase after reset status This bit shows the status of the protection for SRAM2, BKPRAM, ICACHE, DCACHE, ICACHE and PKA. It is set by hardware and reset by software
    $10 constant SBS_IPMEE                      \ [0x10] end-of-erase status for ICACHE and PKA RAM This bit shows the status of the protection for ICACHE and PKA. It is set by hardware and reset by software.
  [then]


  [ifdef] SBS_SBS_CCCSR_DEF
    \
    \ @brief SBS compensation cell for I/Os control and status register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant SBS_EN1                        \ [0x00] enable compensation cell for VDDIO power rail This bit enables the I/O compensation cell.
    $01 constant SBS_CS1                        \ [0x01] code selection for VDDIO power rail (reset value set to 1) This bit selects the code to be applied for the I/O compensation cell.
    $02 constant SBS_EN2                        \ [0x02] enable compensation cell for VDDIO2 power rail This bit enables the I/O compensation cell.
    $03 constant SBS_CS2                        \ [0x03] code selection for VDDIO2 power rail (reset value set to 1) This bit selects the code to be applied for the I/O compensation cell.
    $08 constant SBS_RDY1                       \ [0x08] VDDIO compensation cell ready flag This bit provides the status of the compensation cell.
    $09 constant SBS_RDY2                       \ [0x09] VDDIO2 compensation cell ready flag This bit provides the status of the VDDIO2 compensation cell.
  [then]


  [ifdef] SBS_SBS_CCVALR_DEF
    \
    \ @brief SBS compensation cell for I/Os value register
    \ Address offset: 0x114
    \ Reset value: 0x00000088
    \
    $00 constant SBS_ANSRC1                     \ [0x00 : 4] compensation value for the NMOS transistor This value is provided by the cell and must be interpreted by the processor to compensate the slew rate in the functional range.
    $04 constant SBS_APSRC1                     \ [0x04 : 4] compensation value for the PMOS transistor This value is provided by the cell and must be interpreted by the processor to compensate the slew rate in the functional range.
    $08 constant SBS_ANSRC2                     \ [0x08 : 4] Compensation value for the NMOS transistor This value is provided by the cell and must be interpreted by the processor to compensate the slew rate in the functional range.
    $0c constant SBS_APSRC2                     \ [0x0c : 4] compensation value for the PMOS transistor This value is provided by the cell and must be interpreted by the processor to compensate the slew rate in the functional range.
  [then]


  [ifdef] SBS_SBS_CCSWCR_DEF
    \
    \ @brief SBS compensation cell for I/Os software code register
    \ Address offset: 0x118
    \ Reset value: 0x00007878
    \
    $00 constant SBS_SW_ANSRC1                  \ [0x00 : 4] NMOS compensation code for VDD power rails This bitfield is written by software to define an I/O compensation cell code for NMOS transistors of the VDD power rail. This code is applied to the I/O when CS1 is set in SBS_CCSR.
    $04 constant SBS_SW_APSRC1                  \ [0x04 : 4] PMOS compensation code for the VDD power rails This bitfield is written by software to define an I/O compensation cell code for PMOS transistors of the VDDIO power rail. This code is applied to the I/O when CS1 is set in SBS_CCSR.
    $08 constant SBS_SW_ANSRC2                  \ [0x08 : 4] NMOS compensation code for VDDIO power rails This bitfield is written by software to define an I/O compensation cell code for NMOS transistors of the VDD power rail. This code is applied to the I/O when CS2 is set in SBS_CCSR.
    $0c constant SBS_SW_APSRC2                  \ [0x0c : 4] PMOS compensation code for the VDDIO power rails This bitfield is written by software to define an I/O compensation cell code for PMOS transistors of the VDDIO power rail. This code is applied to the I/O when CS2 is set in SBS_CCSR.
  [then]


  [ifdef] SBS_SBS_CFGR2_DEF
    \
    \ @brief SBS Class B register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant SBS_CLL                        \ [0x00] core lockup lock This bit is set by software and cleared only by a system reset. It can be used to enable and lock the lockup (HardFault) output of Cortex-M33 with TIM1/8/15/16/17 break inputs.
    $01 constant SBS_SEL                        \ [0x01] SRAM ECC error lock This bit is set by software and cleared only by a system reset. It can be used to enable and lock the SRAM double ECC error signal with break input of TIM1/8/15/16/17.
    $02 constant SBS_PVDL                       \ [0x02] PVD lock This bit is set by software and cleared only by a system reset. It can be used to enable and lock the PVD connection with TIM1/8/15/16/17 break inputs.
    $03 constant SBS_ECCL                       \ [0x03] ECC lock This bit is set and cleared by software. It can be used to enable and lock the Flash memory double ECC error with break input of TIM1/8/15/6/17.
  [then]


  [ifdef] SBS_SBS_CNSLCKR_DEF
    \
    \ @brief SBS CPU non-secure lock register
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant SBS_LOCKNSVTOR                 \ [0x00] VTOR_NS register lock This bit is set by software and cleared only by a system reset.
    $01 constant SBS_LOCKNSMPU                  \ [0x01] non-secure MPU register lock This bit is set by software and cleared only by a system reset. When set, this bit disables write access to non-secure MPU_CTRL_NS, MPU_RNR_NS and MPU_RBAR_NS registers.
  [then]


  [ifdef] SBS_SBS_CSLCKR_DEF
    \
    \ @brief SBS CPU secure lock register
    \ Address offset: 0x148
    \ Reset value: 0x00000000
    \
    $00 constant SBS_LOCKSVTAIRCR               \ [0x00] VTOR_S and AIRCR register lock This bit is set by software and cleared only by a system reset. When set, this bit disables write access to VTOR_S register, PRIS and BFHFNMINS bits in the AIRCR register.
    $01 constant SBS_LOCKSMPU                   \ [0x01] secure MPU registers lock This bit is set by software and cleared only by a system reset. When set, this bit disables write access to secure MPU_CTRL, MPU_RNR and MPU_RBAR registers.
    $02 constant SBS_LOCKSAU                    \ [0x02] SAU registers lock This bit is set by software and cleared only by a system reset. When set, this bit disables write access to SAU_CTRL, SAU_RNR, SAU_RBAR and SAU_RLAR registers.
  [then]


  [ifdef] SBS_SBS_ECCNMIR_DEF
    \
    \ @brief SBS flift ECC NMI mask register
    \ Address offset: 0x14C
    \ Reset value: 0x00000000
    \
    $00 constant SBS_ECCNMI_MASK_EN             \ [0x00] NMI behavior setup when a double ECC error occurs on flitf data part
  [then]

  \
  \ @brief SBS register block
  \
  $10 constant SBS_SBS_HDPLCR           \ SBS temporal isolation control register
  $14 constant SBS_SBS_HDPLSR           \ SBS temporal isolation status register
  $18 constant SBS_SBS_NEXTHDPLCR       \ SBS next HDPL control register
  $20 constant SBS_SBS_DBGCR            \ SBS debug control register
  $24 constant SBS_SBS_DBGLOCKR         \ SBS debug lock register
  $34 constant SBS_SBS_RSSCMDR          \ SBS RSS command register
  $A0 constant SBS_SBS_EPOCHSELCR       \ SBS EPOCH selection control register
  $C0 constant SBS_SBS_SECCFGR          \ SBS security mode configuration control register
  $100 constant SBS_SBS_PMCR            \ SBS product mode and configuration register
  $104 constant SBS_SBS_FPUIMR          \ SBS FPU interrupt mask register
  $108 constant SBS_SBS_MESR            \ SBS memory erase status register
  $110 constant SBS_SBS_CCCSR           \ SBS compensation cell for I/Os control and status register
  $114 constant SBS_SBS_CCVALR          \ SBS compensation cell for I/Os value register
  $118 constant SBS_SBS_CCSWCR          \ SBS compensation cell for I/Os software code register
  $120 constant SBS_SBS_CFGR2           \ SBS Class B register
  $144 constant SBS_SBS_CNSLCKR         \ SBS CPU non-secure lock register
  $148 constant SBS_SBS_CSLCKR          \ SBS CPU secure lock register
  $14C constant SBS_SBS_ECCNMIR         \ SBS flift ECC NMI mask register

: SBS_DEF ; [then]
