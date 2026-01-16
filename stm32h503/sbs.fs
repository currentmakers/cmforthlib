\
\ @file sbs.fs
\ @brief System configuration, boot and security
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief SBS temporal isolation control register
\ Address offset: 0x10
\ Reset value: 0x000000B4
\

$000000ff constant SBS_SBS_HDPLCR_INCR_HDPL                         \ increment HDPL value Other: all other values allow a HDPL level increment.


\
\ @brief SBS temporal isolation status register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$000000ff constant SBS_SBS_HDPLSR_HDPL                              \ temporal isolation level This bitfield returns the current temporal isolation level.


\
\ @brief SBS debug control register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$000000ff constant SBS_SBS_DBGCR_AP_UNLOCK                          \ access port unlock Write 0xB4 to this bitfield to open the device access port.
$0000ff00 constant SBS_SBS_DBGCR_DBG_UNLOCK                         \ debug unlock when DBG_AUTH_HDPL is reached Write 0xB4 to this bitfield to open the debug when HDPL in SBS_HDPLSR equals to DBG_AUTH_HDPL in this register.
$00ff0000 constant SBS_SBS_DBGCR_DBG_AUTH_HDPL                      \ authenticated debug temporal isolation level Writing to this bitfield defines at which HDPL the authenticated debug opens. Note: Writing any other values is ignored. Reading any other value means the debug never opens.


\
\ @brief SBS debug lock register
\ Address offset: 0x24
\ Reset value: 0x000000B4
\

$000000ff constant SBS_SBS_DBGLOCKR_DBGCFG_LOCK                     \ debug configuration lock Reading this bitfield returns 0x6A if the bitfield value is different from 0xB4. 0xC3 is the recommended value to lock the debug configuration using this bitfield. Other: Writes to SBS_DBGCR ignored


\
\ @brief SBS product mode and configuration register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000100 constant SBS_SBS_PMCR_BOOSTEN                             \ booster enable Set this bit to reduce the total harmonic distortion of the analog switch when the processor supply is below 2.7 V. The booster can be activated to guaranty AC performance on analog switch when the supply is below 2.7 V. When the booster is activated, the analog switch performances are the same as with the full voltage range.
$00000200 constant SBS_SBS_PMCR_BOOSTVDDSEL                         \ booster V DD selection Note: Booster must not be used when V DDA 2.7 V, but V DD 2.7 V (add current consumption). Note: When both V DD 2.7 V and V DDA 2.7 V, booster is needed to get full AC performances from I/O analog switches.
$00010000 constant SBS_SBS_PMCR_PB6_FMPLUS                          \ Fast-mode Plus command on PB(6)
$00020000 constant SBS_SBS_PMCR_PB7_FMPLUS                          \ Fast-mode Plus command on PB(7)
$00040000 constant SBS_SBS_PMCR_PB8_FMPLUS                          \ Fast-mode Plus command on PB(8)


\
\ @brief SBS FPU interrupt mask register
\ Address offset: 0x104
\ Reset value: 0x0000001F
\

$0000003f constant SBS_SBS_FPUIMR_FPU_IE                            \ FPU interrupt enable Set and cleared by software to enable the Cortex-M33 FPU interrupts FPU_IE[5]: inexact interrupt enable (interrupt disabled at reset) FPU_IE[4]: input abnormal interrupt enable FPU_IE[3]: overflow interrupt enable FPU_IE[2]: underflow interrupt enable FPU_IE[1]: divide-by-zero interrupt enable FPU_IE[0]: invalid operation interrupt enable


\
\ @brief SBS memory erase status register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000001 constant SBS_SBS_MESR_MCLR                                \ erase after reset status This bit shows the status of the protection for SRAM2, BKPRAM, ICACHE, ICACHE. It is set by hardware and reset by software
$00010000 constant SBS_SBS_MESR_IPMEE                               \ end-of-erase status for ICACHE This bit shows the status of the protection for ICACHE. It is set by hardware and reset by software.


\
\ @brief SBS compensation cell for I/Os control and status register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000001 constant SBS_SBS_CCCSR_EN1                                \ enable compensation cell for VDDIO power rail This bit enables the I/O compensation cell.
$00000002 constant SBS_SBS_CCCSR_CS1                                \ code selection for VDDIO power rail (reset value set to 1) This bit selects the code to be applied for the I/O compensation cell.
$00000004 constant SBS_SBS_CCCSR_EN2                                \ enable compensation cell for VDDIO2 power rail This bit enables the I/O compensation cell.
$00000008 constant SBS_SBS_CCCSR_CS2                                \ code selection for VDDIO2 power rail (reset value set to 1) This bit selects the code to be applied for the I/O compensation cell.
$00000100 constant SBS_SBS_CCCSR_RDY1                               \ VDDIO compensation cell ready flag This bit provides the status of the compensation cell.
$00000200 constant SBS_SBS_CCCSR_RDY2                               \ VDDIO2 compensation cell ready flag This bit provides the status of the VDDIO2 compensation cell.


\
\ @brief SBS compensation cell for I/Os value register
\ Address offset: 0x114
\ Reset value: 0x00000088
\

$0000000f constant SBS_SBS_CCVALR_ANSRC1                            \ compensation value for the NMOS transistor This value is provided by the cell and must be interpreted by the processor to compensate the slew rate in the functional range.
$000000f0 constant SBS_SBS_CCVALR_APSRC1                            \ compensation value for the PMOS transistor This value is provided by the cell and must be interpreted by the processor to compensate the slew rate in the functional range.
$00000f00 constant SBS_SBS_CCVALR_ANSRC2                            \ Compensation value for the NMOS transistor This value is provided by the cell and must be interpreted by the processor to compensate the slew rate in the functional range.
$0000f000 constant SBS_SBS_CCVALR_APSRC2                            \ compensation value for the PMOS transistor This value is provided by the cell and must be interpreted by the processor to compensate the slew rate in the functional range.


\
\ @brief SBS compensation cell for I/Os software code register
\ Address offset: 0x118
\ Reset value: 0x00007878
\

$0000000f constant SBS_SBS_CCSWCR_SW_ANSRC1                         \ NMOS compensation code for VDD power rails This bitfield is written by software to define an I/O compensation cell code for NMOS transistors of the VDD power rail. This code is applied to the I/O when CS1 is set in SBS_CCSR.
$000000f0 constant SBS_SBS_CCSWCR_SW_APSRC1                         \ PMOS compensation code for the VDD power rails This bitfield is written by software to define an I/O compensation cell code for PMOS transistors of the VDDIO power rail. This code is applied to the I/O when CS1 is set in SBS_CCSR.
$00000f00 constant SBS_SBS_CCSWCR_SW_ANSRC2                         \ NMOS compensation code for VDDIO power rails This bitfield is written by software to define an I/O compensation cell code for NMOS transistors of the VDD power rail. This code is applied to the I/O when CS2 is set in SBS_CCSR.
$0000f000 constant SBS_SBS_CCSWCR_SW_APSRC2                         \ PMOS compensation code for the V DDIO power rails This bitfield is written by software to define an I/O compensation cell code for PMOS transistors of the VDDIO power rail. This code is applied to the I/O when CS2 is set in SBS_CCSR.


\
\ @brief SBS Class B register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$00000001 constant SBS_SBS_CFGR2_CLL                                \ core lockup lock This bit is set by software and cleared only by a system reset. It can be used to enable and lock the lockup (HardFault) output of Cortex-M33 with TIM1 break inputs.
$00000002 constant SBS_SBS_CFGR2_SEL                                \ SRAM ECC error lock This bit is set by software and cleared only by a system reset. It can be used to enable and lock the SRAM double ECC error signal with break input of TIM1.
$00000004 constant SBS_SBS_CFGR2_PVDL                               \ PVD lock This bit is set by software and cleared only by a system reset. It can be used to enable and lock the PVD connection with TIM1 break inputs.
$00000008 constant SBS_SBS_CFGR2_ECCL                               \ ECC lock This bit is set and cleared by software. It can be used to enable and lock the Flash memory double ECC error with break input of TIM1.


\
\ @brief SBS CPU lock register
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$00000001 constant SBS_SBS_CNSLCKR_LOCKNSVTOR                       \ VTOR_NS register lock This bit is set by software and cleared only by a system reset.
$00000002 constant SBS_SBS_CNSLCKR_LOCKNSMPU                        \ MPU register lock This bit is set by software and cleared only by a system reset. When set, this bit disables write access to MPU_CTRL_NS, MPU_RNR_NS and MPU_RBAR_NS registers.


\
\ @brief SBS flift ECC NMI mask register
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$00000001 constant SBS_SBS_ECCNMIR_ECCNMI_MASK_EN                   \ NMI behavior setup when a double ECC error occurs on flitf data part


\
\ @brief System configuration, boot and security
\
$44000410 constant SBS_SBS_HDPLCR  \ offset: 0x10 : SBS temporal isolation control register
$44000414 constant SBS_SBS_HDPLSR  \ offset: 0x14 : SBS temporal isolation status register
$44000420 constant SBS_SBS_DBGCR  \ offset: 0x20 : SBS debug control register
$44000424 constant SBS_SBS_DBGLOCKR  \ offset: 0x24 : SBS debug lock register
$44000500 constant SBS_SBS_PMCR   \ offset: 0x100 : SBS product mode and configuration register
$44000504 constant SBS_SBS_FPUIMR  \ offset: 0x104 : SBS FPU interrupt mask register
$44000508 constant SBS_SBS_MESR   \ offset: 0x108 : SBS memory erase status register
$44000510 constant SBS_SBS_CCCSR  \ offset: 0x110 : SBS compensation cell for I/Os control and status register
$44000514 constant SBS_SBS_CCVALR  \ offset: 0x114 : SBS compensation cell for I/Os value register
$44000518 constant SBS_SBS_CCSWCR  \ offset: 0x118 : SBS compensation cell for I/Os software code register
$44000520 constant SBS_SBS_CFGR2  \ offset: 0x120 : SBS Class B register
$44000544 constant SBS_SBS_CNSLCKR  \ offset: 0x144 : SBS CPU lock register
$4400054c constant SBS_SBS_ECCNMIR  \ offset: 0x14C : SBS flift ECC NMI mask register

